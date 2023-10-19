using ActionResultInCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ActionResultInCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            int x = 100;
            if (x > 100)
                return View();
            else

            return Json("Data");
        }

        public JsonResult StudentByID(int ID)
        {
            return Json("Json Data");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}