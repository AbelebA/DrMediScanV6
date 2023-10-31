using DrMediScanV6.Data;
using DrMediScanV6.Models;
using DrMediScanV6.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DrMediScanV6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Displays the home page
        public IActionResult Index()
        {
            return View();
        }

        // Displays the privacy policy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Handles errors and displays the error page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Displays information about MRI
        public IActionResult MRIInfo()
        {
            return View();
        }

        // Displays information about a professor
        public IActionResult ProfessorInfo()
        {
            return View();
        }

        // Displays information about clinics and their average rates
        public IActionResult ClinicInfo()
        {
            var clinics = _context.Clinic
                       .Select(c => new ClinicInfo
                       {
                           ClinicName = c.ClinicName,
                           AverageRate = c.AverageRate,
                           Latitude = c.Latitude,
                           Longitude = c.Longitude
                       }).ToList();

            return View(clinics);
        }
    }
}
