using Microsoft.AspNetCore.Mvc;

namespace RentaCar.Core.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
