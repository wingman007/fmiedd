using SpaceInvader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceInvader.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (SecurityService.LoggedUser != null)
            {
                return RedirectToAction("Menu", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            SecurityService.Authenticate(username, password);

            if (SecurityService.LoggedUser == null)
            {
                ModelState.AddModelError("fail", "Wrong username or password!");
                return View();
            }

            return RedirectToAction("Menu", "Home");
        }

        [HttpGet]
        public ActionResult Register()
        {
            if (SecurityService.LoggedUser != null)
            {
                return RedirectToAction("Menu", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Register(string username, string password)
        {
            if (username == "" || password == "")
            {
                ModelState.AddModelError("fail", "Oops... try again!");
                return View();
            }

            SecurityService.Create(username, password);

            return RedirectToAction("Menu", "Home");
        }

        [HttpGet]
        public ActionResult Menu() 
        {
            if (SecurityService.LoggedUser == null)
            {
                return RedirectToAction("Index", "Home");
            }

            List<User> Score = SecurityService.Score();

            return View(Score);
        }

        public ActionResult Game()
        {
            if (SecurityService.LoggedUser == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult SaveGameScore(int score) 
        {
            if (SecurityService.LoggedUser.MaxScore < score)
            {
                SecurityService.SaveScore(score);
            }

            return new EmptyResult();
        }

        public ActionResult Logout() 
        {
            SecurityService.Logout();
            Session["LoggedUser"] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}