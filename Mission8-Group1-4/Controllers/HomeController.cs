using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission8_Group1_4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8_Group1_4.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //I added an Edit View Page here - Anna
        public IActionResult Edit()
        {
            return View();
        }

        private TaskContext taskContext { get; set; }

        // Controller for displaying each task
        public HomeController(TaskContext somename)
        {
            taskContext = somename;
        }
        public IActionResult Quadrants()
        {
            var submittals = taskContext.tasks
                .Include(i => i.Category)
                .OrderBy(i => i.Quadrant)
                .ToList();


            return View(submittals);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.categories = taskContext.categories.ToList();

            var task = taskContext.tasks.Single(i => i.TaskId == id);

            return View("Edit", task);
        }

        [HttpPost]
        public IActionResult Edit(TaskList x)
        {
            if (ModelState.IsValid)
            {
                taskContext.Update(x);
                taskContext.SaveChanges();
                return RedirectToAction("Quadrants");
            }
            else
            {
                ViewBag.Categories = taskContext.categories.ToList();

                return View("Edit", x);
            }

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var task = taskContext.tasks.Single(i => i.TaskId == id);
            return View(task);
        }
        [HttpPost]
        public IActionResult Delete(TaskList x1)
        {
            taskContext.tasks.Remove(x1);
            taskContext.SaveChanges();

            return RedirectToAction("Quadrants"); 
        }


        //You'll need to add a controller for the Confirmation Page - Anna


    }
}
