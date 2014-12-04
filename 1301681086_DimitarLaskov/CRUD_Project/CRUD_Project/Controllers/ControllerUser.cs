using CRUD_Project.Models;
using CRUD_Project.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Project.Controllers
{
    class ControllerUser
    {
        private Models.ModelUser user1;

        public static User currentUser;

        DataClasses1DataContext db;

        public ControllerUser(Models.ModelUser user1)
        {
            this.user1 = user1;
        }

        public ControllerUser()
        {
            db = new DataClasses1DataContext();
        }

        public User LoginAuthentication(string username, string pass)
        {
            var user = (from u in db.Users
                       where u.Username == username && u.Password == pass
                       select u).FirstOrDefault();
            return user;
        }

        public bool Register(string username, string pass, string email)
        {
            var usernames = from un in db.Users
                            select un.Username;

            if (!usernames.Contains(username))
            {
                db.Users.InsertOnSubmit(new User { Username = username, Password = pass, Email = email, RoleID = 1});
                db.SubmitChanges();
                return true;
            }

            return false;
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();

        }

        public bool Delete(int id)
        {
            var user = (from u in db.Users
                       where u.Id == id
                       select u).FirstOrDefault();

            if (user.Id != currentUser.Id)
            {
                db.Users.DeleteOnSubmit(user);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public User GetById(int userId)
        {
            var user = (from u in db.Users
                        where u.Id == userId
                        select u).FirstOrDefault();

            return user;
        }

        public void Edit(User newUser)
        {
            User user = (from u in db.Users
                         where u.Id == newUser.Id
                         select u).FirstOrDefault();

            user.Username = newUser.Username;
            user.Password = newUser.Password;
            user.RoleID = newUser.RoleID;
            user.Email = newUser.Email;

            db.SubmitChanges();
        }
    }
}
