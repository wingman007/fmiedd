using System;
using ConsolePhonebookDB.View;

namespace ConsolePhonebookDB
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Login login = new Login();
                login.Show();

                ContactManager contactManager = new ContactManager();
                contactManager.Show();
            }  
        }
    }
}
