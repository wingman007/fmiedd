using ConsolePhonebook.Entity;
using ConsolePhonebook.Repository;
using System;

namespace ConsolePhonebook.Service
{
    public  class AuthenticationService
    {
        public  User LoggedUser { get; private set; }

        public  void AuthenticateUser(string username, string password)
        {
            UsersRepository userRepo = new UsersRepository(); 
            LoggedUser = userRepo.GetByUsernameAndPassword(username, password);
        }
		
		public static string connectionstring=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\PC\Source\Repos\fmiedd\Ani_Krivova_1301681024_CRUD_Project\CRUD\PhonebookWithACCSESS\ConsolePhonebook\Service\MyPhonebook.mdb";
    }
}
