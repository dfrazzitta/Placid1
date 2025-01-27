using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Placid1.Models;


/*
 * docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=tvxs721#3TTv" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
 
 dotnet ef migrations add InitialCreate --context ApplicationDBContext --output-dir Migrations/ApplicationDBContextMigrations
dotnet ef migrations add InitialCreate --context SchoolContext --output-dir Migrations/SchoolContextMigrations
 
 
 */


namespace Placid1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebHostEnvironment _env;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Location()
        {
            return View();
        }

        public IActionResult ParkPlan()
        {
            return View();
        }

        public IActionResult ForSale()
        {
            return View();
        }


        public IActionResult Calender()
        {
            return View();
        }

        public IActionResult Rules()
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
