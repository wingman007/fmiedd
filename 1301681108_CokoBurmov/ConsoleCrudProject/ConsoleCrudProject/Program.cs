using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCrudProject.View;

namespace ConsoleCrudProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
        }
    }
}
