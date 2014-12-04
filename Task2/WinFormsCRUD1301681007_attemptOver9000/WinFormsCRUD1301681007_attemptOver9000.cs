using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCRUD1301681007_attemptOver9000
{
    static class Project
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin loginForm = new frmLogin();

            DialogResult loginResult = loginForm.ShowDialog();
            if (loginResult == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
            
        }
    }
}
