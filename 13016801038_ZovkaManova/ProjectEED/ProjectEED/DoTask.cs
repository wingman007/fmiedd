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
    public partial class DoTask : Form
    {
        private Tassk task;

        public void SetTask(Tassk task)
        {
            this.task = task;
        }

        public Tassk GetTask()
        {
            return this.task;
        }
        public DoTask()
        {
            InitializeComponent();
        }

        private void DoTask_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = task.Description;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoggedTask loggedTask = new LoggedTask();
            TasksRepository tasksRepo = new TasksRepository();
            LoggedTasksRepository loggedTasksRepo = new LoggedTasksRepository();

            loggedTask.LoggedTime = double.Parse(textBox1.Text);
            loggedTask.Task = task.Name;
            loggedTask.Finsihed = false;
            loggedTask.ParentUserID = AuthenticationService.LoggedUser.ID;


            loggedTasksRepo.EditTask(loggedTask);
            tasksRepo.Delete(task);
            ManageTasks form = new ManageTasks();
            form.Show();
            this.Close();

        }
    }
}
