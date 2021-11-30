using RailwaySchedule.Models;
using RailwaySchedule.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RailwaySchedule.Controllers
{
    public class ScheduleController : Controller
    {
        private ScheduleService _scheduleService = new ScheduleService();
        public ActionResult Index()
        {
            return View(_scheduleService.GetAllSchedules());
        }

        public ActionResult Details(int id)
        {
            return View(_scheduleService.GetScheduleById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Schedule schedule)
        {
            try
            {
                _scheduleService.AddSchedule(schedule);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(_scheduleService.GetScheduleById(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Schedule schedule)
        {
            try
            {
                schedule.Id = id;
                _scheduleService.Update(schedule);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(_scheduleService.GetScheduleById(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, Schedule schedule)
        {
            try
            {
                _scheduleService.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
