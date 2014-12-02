using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManager.Controller;

namespace BookManager
{
    public partial class ViewAll : Form
    {
        private User LoggedUser = new User();
        public ViewAll(User user)
        {
            LoggedUser = user;
            InitializeComponent();
        }

        public ViewAll()
        {
        }

        private void DeactivateMenuOptions()
        {
            editBookDetailsToolStripMenuItem.Visible = false;
            addDeleteBookToolStripMenuItem.Visible = false;
        }

        private void PopulateTable()
        {
            this.titlePanel.Controls.Clear();
            this.authorPanel.Controls.Clear();
            this.pricePanel.Controls.Clear();
            this.isbnPanel.Controls.Clear();

            List<Book> books = new List<Book>();
            books = BookController.GetBooks();
            foreach (Book singleBook in books)
            {
                ViewLabel titleLabel = new ViewLabel();
                ViewLabel authorLabel = new ViewLabel();
                ViewLabel priceLabel = new ViewLabel();
                ViewLabel isbnLabel = new ViewLabel();

                titleLabel.Text = singleBook.Title;
                authorLabel.Text = singleBook.Author;
                priceLabel.Text = singleBook.Price;
                isbnLabel.Text = singleBook.ISBN;

                this.titlePanel.Controls.Add(titleLabel);
                this.authorPanel.Controls.Add(authorLabel);
                this.pricePanel.Controls.Add(priceLabel);
                this.isbnPanel.Controls.Add(isbnLabel);
            }
        }

        private void editBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindBook addBookform = new FindBook(LoggedUser);
            addBookform.Show();
            this.Hide();
        }

        private void addDeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addBookform = new AddBook(LoggedUser);
            addBookform.Show();
            this.Hide();
        }

        private void splashPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookManager bookManagerform = new BookManager(LoggedUser);
            bookManagerform.Show();
            this.Hide();
        }

        private void viewAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            if (LoggedUser.role_id == 2)
            {
                DeactivateMenuOptions();
            }

            PopulateTable();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();
            this.Hide();
        }

    }
}
