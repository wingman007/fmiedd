using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookManager
{
    public partial class BookManager : Form
    {
        private User LoggedUser = new User();

        public BookManager(User user)
        {
            LoggedUser = user;
            InitializeComponent();
        }

        public BookManager()
        {
            
        }

        private void DeactivateMenuOptions() 
        {
            editBookDetailsToolStripMenuItem.Visible = false;
            addDeleteBookToolStripMenuItem.Visible = false;
        }


        private void viewAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAll viewAllform = new ViewAll(LoggedUser);
            viewAllform.Show();
            this.Hide();
        }

        private void editBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindBook findBookform = new FindBook(LoggedUser);
            findBookform.Show();
            this.Hide();
        }

        private void addDeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBookform = new AddBook(LoggedUser);
            addBookform.Show();
            this.Hide();
        }

        private void BookManager_Load(object sender, EventArgs e)
        {
            if (LoggedUser.role_id == 1)
            {
                lb_welcome.Text = "Welcome, " + LoggedUser.username + ". You may perform any action on the books database.";
            }
            else
            {
                lb_welcome.Text = "Welcome, " + LoggedUser.username + ". You may view all the books in the database.";
                DeactivateMenuOptions();

            }
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();
            this.Hide();
        }

    }
}
