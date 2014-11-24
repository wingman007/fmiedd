using CrudWebProject.Context;
using CrudWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CrudWebProject.Controllers
{
    public class UserController : Controller
    {
        private UserContext db = new UserContext();
        //User
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        //Details
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            User user = db.Users.Find(id);
            if (user == null)
                return HttpNotFound();
            return View(user);
            
        }

       //Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                return RedirectToAction("Index");
                }
                return View(user);
            }
            catch
            {
                return View();
            }
        }

        //Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            User user = db.Users.Find(id);
            if (user == null)
                return HttpNotFound();
            return View(user);
        }

        //Edit
        [HttpPost]
        public ActionResult Edit(User user  )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(user);
              }
            catch
            {
                return View();
            }
        }

        //Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            User user = db.Users.Find(id);
            if (user == null)
                return HttpNotFound();
            return View(user);
        }

        //Delete
        [HttpPost]
        public ActionResult Delete(int? id , User us )
        {
            try
            {
                User user = new User();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                     user = db.Users.Find(id);
                    if (user == null)
                        return HttpNotFound();
                    db.Users.Remove(user);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(user);
            }
            catch
            {
                return View();
            }
        }
    }
}
