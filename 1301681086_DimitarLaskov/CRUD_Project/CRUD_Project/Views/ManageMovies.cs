using CRUD_Project.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Project.Views
{
    public partial class ManageMovies : MetroFramework.Forms.MetroForm
    {
        public ManageMovies()
        {
            InitializeComponent();
        }

        private void EditDelMovie_Load(object sender, EventArgs e)
        {
            ControllerMovie ctrlMovie = new ControllerMovie();
            ctrlMovie.LoadMoviesToListView(listView1);
            metroComboBox1.Items.AddRange(ControllerCategory.LoadAllCategories());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ManageMovies_Activated(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ControllerMovie ctrlMovie = new ControllerMovie();
            ctrlMovie.LoadMoviesToListView(listView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ControllerMovie ctrlMovie = new ControllerMovie();
                ctrlMovie.DeleteMovie(Convert.ToInt32(listView1.SelectedItems[0].Text));
                ManageMovies_Activated(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("No items are selected!");
            }


        }

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            EditMovies editMovie = new EditMovies(Convert.ToInt32(listView1.SelectedItems[0].Text));
            editMovie.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
