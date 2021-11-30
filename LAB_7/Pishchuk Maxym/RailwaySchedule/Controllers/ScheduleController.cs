using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ScheduleBL.Services;
using ScheduleDL.Models;

namespace RailwaySchedule.Controllers
{
    public class ScheduleController : Controller
    {
        private IScheduleService _scheduleService;
        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }
        public async Task<ActionResult> Index()
        {
            return View(await _scheduleService.GetAllAsync());
        }

        public async Task<ActionResult> Details(int id)
        {
            return View(await _scheduleService.GetByIdAsync(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Create(Schedule schedule)
        {
            try
            {
                await _scheduleService.CreateAsync(schedule);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            return View(await _scheduleService.GetByIdAsync(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Schedule schedule)
        {
            try
            {
                schedule.Id = id;
                await _scheduleService.UpdateAsync(schedule);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            return View(await _scheduleService.GetByIdAsync(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Schedule schedule)
        {
            try
            {
                await _scheduleService.DeleteAsync(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
