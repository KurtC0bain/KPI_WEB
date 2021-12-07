using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using lab7_mvc_audiolibrary.Models;

namespace lab7_mvc_audiolibrary.Controllers
{
    public class HomeController : Controller
    {
        AudioContext db = new AudioContext();

        public ActionResult Index()
        {
            var audios = db.AudioLibrary.Include(x => x.Audio);
            return View(audios.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            SelectList audios = new SelectList(db.AudioLibrary, "Id", "Name");
            ViewBag.Audios = audios;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Audio audio)
        {
            db.AudioLibrary.Add(audio);
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
            Audio audio = db.AudioLibrary.Find(id);
            if (audio != null)
            {
                SelectList audios = new SelectList(db.AudioLibrary, "Id", "Name", audio.ID);
                ViewBag.Audios = audios;
                return View(audio);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Audio audio)
        {
            db.Entry(audio).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Audio audio = db.AudioLibrary.Find(id);

            if (audio != null)
            {
                db.AudioLibrary.Remove(audio);
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