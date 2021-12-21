using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab9.Models;
using System.Data.Entity;

namespace lab9.Controllers
{
    public class HomeController : Controller
    {
        TaskContext db = new TaskContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TaskSearch(string name)
        {
            var alltasks = db.Tasks.Where(a => a.Date.Contains(name)).ToList();
            return PartialView(alltasks);
        }


        [HttpGet]
        public ActionResult Create()
        {
            SelectList tasks = new SelectList(db.Tasks, "Id", "Name");
            ViewBag.Albums = tasks;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Task player = db.Tasks.Find(id);
            if (player != null)
            {
                SelectList albums = new SelectList(db.Tasks, "Id", "Name", player.Id);
                ViewBag.Tasks = albums;
                return View(player);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Task task)
        {
            db.Entry(task).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }




        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Task photo = db.Tasks.Find(id);

            if (photo != null)
            {
                db.Tasks.Remove(photo);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}