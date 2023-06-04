using Microsoft.AspNetCore.Mvc;
using RentaCar.BLL.DesignPatterns.GenericRepository.ConcRep;

namespace RentaCar.Core.Controllers
{
    public class CarController : Controller
    {
        private readonly CarRepository _carRepository;

        public CarController(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            return View(_carRepository.GetActive());
        }
        public IActionResult Details(int id)
        {
            var car = _carRepository.Find(id);            
            return View(car);
        }
    }
}
