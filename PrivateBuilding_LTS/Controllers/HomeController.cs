using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PrivateBuilding_LTS.Data;
using PrivateBuilding_LTS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateBuilding_LTS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> News(string sortOrder, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desec" : "Date";

            var news = from n in _context.News 
                       select n;

            switch (sortOrder)
            {
                case "name_desc":
                    news = news.OrderByDescending(n => n.Id);
                    break;
                case "Date":
                    news = news.OrderBy(n => n.PostDate);
                    break;
                case "date_desc":
                    news = news.OrderByDescending(n => n.PostDate);
                    break;
                default:
                    news = news.OrderBy(n => n.Id);
                    break;
            }

            int pageSize = 3;
            return View(await PaginatedList<New>.CreateAsync(news.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
