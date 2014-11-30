using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task.Source;
using System.Data.SqlServerCe;

namespace Task
{
    public partial class frmUserInfo : Form
    {
        public frmUserInfo()
        {
            InitializeComponent();

            LoggedUserCheck();
        }
        private void LoggedUserCheck()
        {
            SqlCeConnection sqlConnection = new SqlCeConnection();
            sqlConnection.ConnectionString = Auth.ConnectionDBString;

            SqlCeCommand sqlCommand = new SqlCeCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from Users where username='" + frmLogin.loggedUser + "'";
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlCeDataReader rd = sqlCommand.ExecuteReader();
            while (rd.Read())
            {
                tbUsername.Text = rd.GetValue(0).ToString();
                tbNames.Text = rd.GetValue(1).ToString();
                tbPassword.Text = rd.GetValue(2).ToString();
                tbAdmin.Text = rd.GetValue(3).ToString();
            }
            sqlConnection.Close();
        }
    }
}
