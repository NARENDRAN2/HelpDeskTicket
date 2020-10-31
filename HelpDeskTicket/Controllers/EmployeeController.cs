using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpDeskTicket.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskTicket.Controllers
{
    public class EmployeeController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
