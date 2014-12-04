using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_Project.Controllers;
using CRUD_Project.Models;
using CRUD_Project.Views;

namespace CRUD_Project.View
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private ControllerMovie ctrlMovie;

        public Main()
        {
            InitializeComponent();
            ctrlMovie = new ControllerMovie();
        }

        public Form mainForm { get; set; }

        private void Main_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = ControllerUser.currentUser.Username;
            toolStripStatusLabelRoleName.Text = ControllerUser.currentUser.Role.RoleName;

            if (ControllerUser.currentUser.Role.RoleName == "Member" || ControllerUser.currentUser.Role.RoleName == "Public")
            {
                adminPanelToolStripMenuItem.Visible = false;
                manageToolStripMenuItem.Visible = false;
                addToolStripMenuItem1.Visible = false;
            }

            ctrlMovie.LoadMoviesToListView(listView1);
            metroComboBox1.Items.Add("All Genres...");
            metroComboBox1.Items.AddRange(ControllerCategory.LoadAllCategories());
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddMovies addMovies = new AddMovies();
            addMovies.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowMovie a = new ShowMovie();
            ModelMovie.MovieID = Convert.ToInt32(listView1.SelectedItems[0].Text);
            a.Show();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            metroComboBox1.Items.Clear();
            ControllerMovie ctrlMovie = new ControllerMovie();
            ctrlMovie.LoadMoviesToListView(listView1);
            metroComboBox1.Items.Add("All Genres...");
            metroComboBox1.Items.AddRange(ControllerCategory.LoadAllCategories());
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMovies manage = new ManageMovies();
            manage.Show();
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdminPanel adminPanel = new UserAdminPanel();
            adminPanel.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (metroTextBox1.Text == "" || metroComboBox1.SelectedItem == null)
            {
                return;
            }

            List<Movy> movies = ctrlMovie.GetByCondition(metroTextBox1.Text,
                                metroComboBox1.SelectedItem.ToString(), metroDateTime1.Value.Year);



            int count = 0;
            foreach (var item in movies)
            {
                listView1.Items.Add(item.Id.ToString());
                listView1.Items[count].SubItems.Add(item.Title);
                listView1.Items[count].SubItems.Add(item.Category1.CategoryName);
                listView1.Items[count].SubItems.Add(item.Year.ToString());
                listView1.Items[count].SubItems.Add(item.Director);
                listView1.Items[count].SubItems.Add(item.User.Username);
                count++;
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ControllerMovie ctrlMovie = new ControllerMovie();
            ctrlMovie.LoadMoviesToListView(listView1);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = String.Empty;
        }
    }
}
