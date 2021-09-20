using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13.Controllers
{
    public class ABCController1 : Controller
    {
        // GET: ABCController1
        public ActionResult Index()
        {
            var a = 0;
            return View();
        }

        
        // GET: ABCController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ABCController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ABCController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ABCController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ABCController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ABCController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ABCController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
