using Microsoft.AspNetCore.Mvc;

namespace Batranu_Alexandru_Lab1.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
