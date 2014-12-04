﻿using CRUD_Project.Models;
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
using System.IO;

namespace CRUD_Project.Views
{
    public partial class AddMovies : MetroFramework.Forms.MetroForm
    {
        public AddMovies()
        {
            InitializeComponent();
        }

        ControllerCategory ctrCat;

        private void AddMovies_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.AddRange(ControllerCategory.LoadAllCategories());
        }

        private void SubmitTheMovie(int category)
        {
            Movy movie = new Movy
            {
                Category = category + 1,
                Title = textBoxTitle.Text,
                Cast = textBoxCast.Text,
                Director = textBoxDirector.Text,
                Year = Convert.ToInt32(dateTimePickerYear.Text),
                Country = textBoxCountry.Text,
                Description = textBoxDescr.Text,
                UserId = ControllerUser.currentUser.Id
            };

            ControllerMovie ctrlMovie = new ControllerMovie();
            ctrlMovie.AddMovie(movie);

            DialogResult result =
                MessageBox.Show("Movie successfully added to the catalogue! \n Do you want to exit?", "Successfull operation!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                textBoxNewCat.Enabled = true;
                comboBoxCategory.Enabled = false;
            }
            else
            {
                textBoxNewCat.Enabled = false;
                comboBoxCategory.Enabled = true;
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var controls = new[] 
            { 
                textBoxCast,
                textBoxCountry, 
                textBoxDescr, 
                textBoxDirector, 
                textBoxNewCat, 
                textBoxTitle 
            };

            foreach (var item in controls)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    MessageBox.Show("Empty entries not allowed!", "Warining!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    item.Focus();
                    return;
                }
            }

            int category;

            if (metroCheckBox1.Checked == true)
            {
                ctrCat = new ControllerCategory(new Category { CategoryName = textBoxNewCat.Text });
                category = ctrCat.InsertNewCategory();

                if (category == -1)
                {
                    MessageBox.Show("This category already exist!", "Warining!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                category = comboBoxCategory.SelectedIndex;
                ctrCat = new ControllerCategory(new Category { CategoryName = comboBoxCategory.SelectedText });
            }

            SubmitTheMovie(category);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            textBoxCast.Clear();
            textBoxCountry.Clear();
            textBoxDescr.Clear();
            textBoxDirector.Clear();
            textBoxNewCat.Clear();
            textBoxTitle.Clear();
            textBoxTitle.Focus();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
