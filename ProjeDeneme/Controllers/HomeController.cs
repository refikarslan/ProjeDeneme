using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjeDeneme.Models;
using System.Diagnostics;

namespace ProjeDeneme.Controllers
{
    public class HomeController : Controller
    {

        
        private readonly ILogger<HomeController> _logger;
private readonly Context context;
        public HomeController(Context context, ILogger<HomeController> logger)
        {
            this.context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(Users p1)
        {
            context.Users.Add(p1);
            
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }




    }
}