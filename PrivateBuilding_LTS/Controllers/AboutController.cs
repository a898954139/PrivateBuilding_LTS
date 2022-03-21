using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PB.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Explain()
        {
            return View();
        }
        public IActionResult ProInfo()
        {
            return View();
        }
        public IActionResult QA()
        {
            return View();
        }
        public IActionResult LFE()
        {
            return View();
        }
    }
}
