using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RentaCar.BLL.DesignPatterns.GenericRepository.ConcRep;
using RentaCar.Models;
using System.Diagnostics;

namespace RentaCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarRepository _carRepository;

        public HomeController(ILogger<HomeController> logger, CarRepository carRepository)
        {
            _logger = logger;
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            return View(_carRepository.GetActive());
        }
        
		public IActionResult Privacy()
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