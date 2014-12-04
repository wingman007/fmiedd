using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDB.ControlForms
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.studentsDS.Users);
            this.statusLabel.Text = "We have: " + dataGridView2.RowCount.ToString() + " records in the system.";
        }
    }
}
