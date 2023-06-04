using Microsoft.AspNetCore.Mvc;

namespace RentaCar.Core.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
