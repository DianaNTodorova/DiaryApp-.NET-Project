using Microsoft.AspNetCore.Mvc;

namespace DiaryAPP.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to your first ASP.NET MVC app!";

            return View();
        }
    }
}
