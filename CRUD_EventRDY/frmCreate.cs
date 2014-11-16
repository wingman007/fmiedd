﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_EventRDY
{
    public partial class frmCreate : Form
    {
        public static string register = null;

        public frmCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ConnectDB.RegisterME(tbUsr.Text, tbNames.Text, tbPass.Text, tbEmail.Text);

            MessageBox.Show(register);
            if (register != "Username already exists!")
            {
                this.Close();
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
