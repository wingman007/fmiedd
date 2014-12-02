using ProjectEED.Entity;
using ProjectEED.Repository;
using ProjectEED.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEED
{
    public partial class ManageTasks : Form
    {
        public ManageTasks()
        {
            InitializeComponent();
        }
        public void RefreshTasks()
        {
            User user = AuthenticationService.LoggedUser;
            listBox1.Items.Clear();
            TasksRepository tasksRepo = new TasksRepository();
            foreach(Tassk task in tasksRepo.GetAll(user.ID))
            {
                listBox1.Items.Add(task);
            }
        }
        public void RefreshAllTasks()
        {
       
            listBox1.Items.Clear();
            TasksRepository tasksRepo = new TasksRepository();
            foreach (Tassk task in tasksRepo.GetAll())
            {
                listBox1.Items.Add(task);
            }
        }
        public void RefreshLoggedTasks()
        {
            User user = AuthenticationService.LoggedUser;
            LoggedTasksRepository loggedtasksRepo = new LoggedTasksRepository();
            listBox2.Items.Clear();
            foreach (LoggedTask loggedTask in loggedtasksRepo.GetAll(user.ID))
            {
                listBox2.Items.Add(loggedTask);
            }
        }
        public void RefreshAllLoggedTasks()
        {
           
            LoggedTasksRepository loggedtasksRepo = new LoggedTasksRepository();
            listBox2.Items.Clear();
            foreach (LoggedTask loggedTask in loggedtasksRepo.GetAll())
            {
                listBox2.Items.Add(loggedTask);
            }
        }
        private void ManageTasks_Load(object sender, EventArgs e)
        {
           
            if(AuthenticationService.LoggedUser.RoleID!=1)
            {
                toolStripButton1.Visible = false;
                toolStripButton2.Visible = false;
                toolStripButton3.Visible = false;
                toolStripButton4.Visible = true;
                RefreshTasks();
                RefreshLoggedTasks();
            }
            toolStripButton4.Visible = true;
            RefreshAllTasks();
            RefreshAllLoggedTasks();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Task form = new Task();
            form.Show();
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Tassk task = (Tassk)listBox1.SelectedItem;
            if(task==null)
            {
                MessageBox.Show("Please select a task!");
                return;
            }
            else
            {
                Task form = new Task();
                form.SetTask(task);
                form.Show();
                this.Close();
            }


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Tassk task = (Tassk)listBox1.SelectedItem;
            if(task==null)
            {
                MessageBox.Show("Please select a task!");
                return;
            }
            else
            {
                TasksRepository tasksRepo = new TasksRepository();
                tasksRepo.Delete(task);

                RefreshTasks();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Tassk task = (Tassk)listBox1.SelectedItem;
            if(task==null)
            {
                MessageBox.Show("Please select a task!");
                return;
            }
            DoTask form = new DoTask();
            form.SetTask(task);
            form.Show();
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            LoggedTask loggedTask = (LoggedTask)listBox2.SelectedItem;
            if (loggedTask == null)
            {
                MessageBox.Show("Please select a task!");
                return;
            }
            {
                LoggedTasksRepository loggedtasksRepo = new LoggedTasksRepository();
                if (AuthenticationService.LoggedUser.ID != loggedTask.ParentUserID)
                {
                    MessageBox.Show("You cannot change the status of other task!");
                    return;
                }
                else
                {
                    if (loggedTask.Finsihed == true)
                    {
                        MessageBox.Show("This task is already finished!");
                        return;
                    }
                    else
                    {
                        loggedTask.Finsihed = true;
                        loggedtasksRepo.EditTask(loggedTask);

                        RefreshLoggedTasks();
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoggedTask loggedTask = (LoggedTask)listBox2.SelectedItem;
            LoggedTasksRepository loggedtasksRepo = new LoggedTasksRepository();
            if (loggedTask == null)
            {
                MessageBox.Show("Please select a task!");
                return;
            }
            else
            {
                if (AuthenticationService.LoggedUser.ID != loggedTask.ParentUserID)
                {
                    MessageBox.Show("You cannot change the status of other task!");
                }
                else
                {
                    if (loggedTask.Finsihed == false)
                    {
                        MessageBox.Show("This task is yet in progress!");
                        return;
                    }
                    else
                    {
                        loggedTask.Finsihed = false;
                        loggedtasksRepo.EditTask(loggedTask);

                        RefreshLoggedTasks();
                    }

                }
            }
        }
    }
}
