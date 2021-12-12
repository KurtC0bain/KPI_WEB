using laba7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace lab7.Controllers
{
    public class HomeController : Controller
    {
        PhotoContext db = new PhotoContext();
        public ActionResult Index()
        {
            var photos = db.Photos.Include(p => p.Album);
            return View(photos.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            SelectList albums = new SelectList(db.Albums, "Id", "Name");
            ViewBag.Albums = albums;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Photo photo)
        {
            db.Photos.Add(photo);
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
            Photo player = db.Photos.Find(id);
            if (player != null)
            {
                SelectList albums = new SelectList(db.Albums, "Id", "Name", player.AlbumId);
                ViewBag.Albums = albums;
                return View(player);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Photo photo)
        {
            db.Entry(photo).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            Photo photo = db.Photos.Find(id);

            if(photo != null)
            {
                db.Photos.Remove(photo);
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
