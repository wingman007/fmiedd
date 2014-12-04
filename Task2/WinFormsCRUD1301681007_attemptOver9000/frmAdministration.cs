using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCRUD1301681007_attemptOver9000.dsUsersTableAdapters;

namespace WinFormsCRUD1301681007_attemptOver9000
{
    public partial class frmAdministration : Form
    {
        usersTableAdapter taUsers = new usersTableAdapter();

        public frmAdministration()
        {
            InitializeComponent();

            taUsers.Fill(dsUsers.users);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsUsers.users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.dsUsers.users);

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            DataRowView newUser = (DataRowView)usersBindingSource.AddNew();

            frmUser editForm = new frmUser(newUser);
            DialogResult result = editForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                usersBindingSource.EndEdit();
                taUsers.Update(dsUsers);

                dsUsers.users.Clear();
                taUsers.Fill(dsUsers.users);
            }
            else
                usersBindingSource.CancelEdit();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Current == null)
                return;

            DataRowView editingUser = (DataRowView)usersBindingSource.Current;

            frmUser editForm = new frmUser(editingUser);
            DialogResult result = editForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                usersBindingSource.EndEdit();
                taUsers.Update(dsUsers);
            }
            else
                usersBindingSource.CancelEdit();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Current == null)
                return;

            DialogResult result = MessageBox.Show(
                            "Delete user",
                            "Delete user",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                try
                {
                    usersBindingSource.RemoveCurrent();
                    taUsers.Update(dsUsers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Delete failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    usersBindingSource.CancelEdit();
                    dsUsers.RejectChanges();
                }
            }
        }
    }
}
