using BugReporterApp.Data;
using BugReporterApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BugReporterApp.Controllers
{
    public class BugController : Controller
    {
        public IActionResult Index()
        {
            var bugs = BugRepository.GetAll();
            return View(bugs);
        }

        public IActionResult Create()//display an empty form
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Bug bug)// validate and save a new bug
        {
            if (ModelState.IsValid)
            {
                BugRepository.Add(bug);
                return RedirectToAction("Index");
            }
            return View(bug);
        }
    }
}
