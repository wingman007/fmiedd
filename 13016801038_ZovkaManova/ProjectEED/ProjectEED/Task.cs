using ProjectEED.Entity;
using ProjectEED.Repository;
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
    public partial class Task : Form
    {
        private Tassk task;

        public void SetTask(Tassk task)
        {
            this.task = task;
        }

        public Tassk GetTask()
        {
            return task;
        }
        public Task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TasksRepository tasksRepo = new TasksRepository();
            User user = (User)comboBox1.SelectedItem;
             if(task!=null)
             {
                 task.ParentUserID = user.ID;
                 task.Name = textBox1.Text;
                 task.Description = textBox1.Text;
                 if(textBox1.Text==""|| richTextBox1.Text=="" || comboBox1.Text=="")
                 {
                     MessageBox.Show("The values cannot be empty!");
                     return;
                 }
                 else
                 {
                     tasksRepo.EditTask(task);
                 }
             
             }
             else
             {
                 Tassk newTask = new Tassk();
                 newTask.ParentUserID = user.ID;
                 newTask.Name = textBox1.Text;
                 newTask.Description = richTextBox1.Text;
                 if (textBox1.Text == "" || richTextBox1.Text == "" || comboBox1.Text == "")
                 {
                     MessageBox.Show("The values cannot be empty!");
                     return;
                 }
                 else
                 {
                     tasksRepo.EditTask(newTask);
                 }
                 
             }
             ManageTasks form = new ManageTasks();
             form.Show();
             this.Close();
        }

        private void Task_Load(object sender, EventArgs e)
        {
            UsersRepository usersRepo = new UsersRepository();
            
            if (task == null)
            {
                foreach (User user in usersRepo.GetAll())
                {
                    comboBox1.Items.Add(user);
                }
            }
            else
            {
                User user = usersRepo.GetByID(task.ParentUserID);
                comboBox1.SelectedItem = user;
                comboBox1.SelectedText = user.ToString();
                textBox1.Text = task.Name;
                richTextBox1.Text = task.Description;

                foreach (User u in usersRepo.GetAll())
                {
                    comboBox1.Items.Add(u);
                }
                
            }
            
        }
    }
}
