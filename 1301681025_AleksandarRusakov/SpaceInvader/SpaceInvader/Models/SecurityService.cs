using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceInvader.Models
{
    public class SecurityService
    {
        public static User LoggedUser
        {
            get
            {
                AuthenticationService authenticationService = null;

                if (HttpContext.Current != null && HttpContext.Current.Session["LoggedUser"] == null)
                    HttpContext.Current.Session["LoggedUser"] = new AuthenticationService();

                authenticationService = (AuthenticationService)HttpContext.Current.Session["LoggedUser"];
                return authenticationService.LoggedUser;
            }
            private set
            {
                LoggedUser = value;
            }
        }

        public static void Authenticate(string username, string password)
        {
            AuthenticationService authServ = null;

            if (HttpContext.Current != null && HttpContext.Current.Session["LoggedUser"] == null)
                HttpContext.Current.Session["LoggedUser"] = new AuthenticationService();

            authServ = (AuthenticationService)HttpContext.Current.Session["LoggedUser"];
            authServ.AuthenticateUser(username, password);
        }

        public static void Create(string username, string password)
        {
            AuthenticationService authServ = null;

            if (HttpContext.Current != null && HttpContext.Current.Session["LoggedUser"] == null)
                HttpContext.Current.Session["LoggedUser"] = new AuthenticationService();

            authServ = (AuthenticationService)HttpContext.Current.Session["LoggedUser"];
            authServ.CreateUser(username, password);
        }

        public static List<User> Score() 
        {
            return (new UsersRepository()).GetScore();
        }

        public static void SaveScore(int score)
        {
            (new UsersRepository()).SaveScore(score);
        }

        public static void Logout()
        {
            HttpContext.Current.Session["LoggedUser"] = null;
        }
    }
}