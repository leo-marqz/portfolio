using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Models.Example;
using Portafolio.Services;
using Portafolio.Services.Examples;
using System;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectRepository projectRepository;

        public HomeController(ILogger<HomeController> logger, 
            IProjectRepository projectRepository)
        {
            _logger = logger;
            this.projectRepository = projectRepository;
        }

        public IActionResult Index()
        {
            var projects = this.projectRepository.GetAll().Take(3).ToList();
            var model = new HomeIndexViewModel() { Projects = projects};
            return View(model);
        }

        public IActionResult Projects()
        {
            var projects = this.projectRepository.GetAll();
            return View(projects);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            return RedirectToAction("Gratitude", "Home"); 
        }

        public IActionResult Gratitude()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}