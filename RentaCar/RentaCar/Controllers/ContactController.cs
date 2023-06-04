using Microsoft.AspNetCore.Mvc;

namespace RentaCar.Core.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
