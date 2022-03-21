using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PB.Controllers
{
    public class AllowanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
