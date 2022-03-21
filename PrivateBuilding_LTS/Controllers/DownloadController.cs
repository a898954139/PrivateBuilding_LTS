using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace PB.Controllers
{
    public class DownloadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
