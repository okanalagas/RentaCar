using Microsoft.AspNetCore.Mvc;

namespace RentaCar.Core.Controllers
{
    public class OfficeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
