using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectWeek10.View;

namespace projectWeek10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Login loginView = new Login();
            loginView.Show();
            
            TableView tableView = new TableView();
            tableView.Show();
        }
    }
}
