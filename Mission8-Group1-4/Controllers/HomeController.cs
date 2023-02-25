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

        public HomeController(TaskContext somename)
        {
            taskContext = somename;
        }
        public IActionResult Quadrants()
        {
            var submittals = taskContext.tasks
                .Include(i => i.Category)
                .ToList();


            return View(submittals);
        }

        //You'll need to add a controller for the Confirmation Page - Anna


    }
}
