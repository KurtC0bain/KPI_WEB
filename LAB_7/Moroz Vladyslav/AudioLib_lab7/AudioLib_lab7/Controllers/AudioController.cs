using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AudioLib_lab7.Controllers
{
    public class AudioController : Controller
    {
        private IAudioService _audioService;

        public AudioController(IAudioService audioService)
        {
            _audioService = audioService;
        }

        // GET: Audio
        public async Task<ActionResult> Index()
        {
            return View(await _audioService.GetAllAsync());
        }

        // GET: Audio/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _audioService.GetByIdAsync(id));
        }

        // GET: Audio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Audio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Audio audio)
        {
            try
            {
                await _audioService.CreateAsync(audio);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Audio/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _audioService.GetByIdAsync(id));
        }

        // POST: Audio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Audio audio)
        {
            try
            {
                audio.Id = id;
                await _audioService.UpdateAsync(audio);
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Audio/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _audioService.DeleteAsync(id));
        }

        // POST: Audio/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Audio audio)
        {
            try
            {
                
                await _audioService.DeleteAsync(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
