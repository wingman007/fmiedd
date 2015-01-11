using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCRUD1301681007_attemptOver9000.Service;

namespace WinFormsCRUD1301681007_attemptOver9000
{
    public partial class frmUser : Form
    {
        private DataRowView _row;

        public frmUser()
        {
            InitializeComponent();
        }

        public frmUser(DataRowView row)
        {
            InitializeComponent();

            this._row = row;

            if (Convert.ToInt32(_row["id"]) > 0)
            {
                this.Text = "Edit User";
                this.tbUsername.Text = Convert.ToString(_row["username"]);
                this.tbPassword.Text = Convert.ToString(_row["password"]);
                this.tbFirstName.Text = Convert.ToString(_row["first_name"]);
                this.tbLastName.Text = Convert.ToString(_row["last_name"]);
                this.cbRole.Text = Convert.ToString(_row["role"]);
            }

            else
                this.Text = "New User";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.Text == "Edit User" || this.Text == "New User")
            {
                _row["username"] = tbUsername.Text;
                _row["password"] = tbPassword.Text;
                _row["first_name"] = tbFirstName.Text;
                _row["last_name"] = tbLastName.Text;
                _row["role"] = cbRole.Text;
            }


            AuthenticationService.Insert(tbUsername.Text, tbPassword.Text, tbFirstName.Text, tbLastName.Text,cbRole.Text);

            this.DialogResult = DialogResult.OK;
        }
    }
}
