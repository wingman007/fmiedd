using ConsoleLibrary.Entity;
using ConsolePhonebook.Entity;
using ConsolePhonebook.Repository;
using System;

namespace ConsolePhonebook.Service
{
    public  class AuthenticationService
    {
        public  User LoggedUser { get; private set; }
       // public Rolles Constraint { get; private set; }

        public  void AuthenticateUser(string username, string password)
        {
            UsersRepository userRepo = new UsersRepository(); 
            LoggedUser = userRepo.GetByUsernameAndPassword(username, password);
         //   Constraint.UserId = LoggedUser.Id;
        }

        public static string connectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PC\Source\Repos\fmiedd\1301681024_Ani_Krivova\Ani_Krivova_1301681024_CRUD_Project\CRUD\PhonebookWithACCSESS\ConsolePhonebook\Service\MyPhonebook.mdb";
    }
}
