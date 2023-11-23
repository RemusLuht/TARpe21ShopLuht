using Microsoft.AspNetCore.Mvc;

namespace TARpe21ShopLuht.Controllers
{
    public class WeatherForecastsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
