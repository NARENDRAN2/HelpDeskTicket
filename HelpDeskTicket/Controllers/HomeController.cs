using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelpDeskTicket.Models;
using Microsoft.AspNetCore.Authorization;

namespace HelpDeskTicket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //ctor, brings in iLogger of type HomeController
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //default action 
        [Authorize]
        public IActionResult Index()
        {
            //View() will return:  [the name of the method].cshtml
            //AKA, index.cshtml
            return View();
        }

        public IActionResult Privacy()
        {
            //View() will return:  [the name of the method].cshtml
            //AKA, privacy.cshtml
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
