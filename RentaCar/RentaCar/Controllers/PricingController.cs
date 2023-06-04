using Microsoft.AspNetCore.Mvc;
using RentaCar.BLL.DesignPatterns.GenericRepository.ConcRep;

namespace RentaCar.Core.Controllers
{
    public class PricingController : Controller
    {
        private readonly CarRepository _carRepository;

        public PricingController(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            return View(_carRepository.GetActive());
        }
    }
}
