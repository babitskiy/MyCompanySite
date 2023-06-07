using Microsoft.AspNetCore.Mvc;

namespace MyCompanySite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
