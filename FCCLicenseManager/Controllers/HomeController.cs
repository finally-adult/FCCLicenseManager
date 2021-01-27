using FCCLicenseManager.Models;
using FCCLicenseManager.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace FCCLicenseManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IFCCHttpHandler handler;

        public HomeController(IFCCHttpHandler handler, ILogger<HomeController> logger)
        {
            this.handler = handler;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            var model = handler.GetData().Licenses.License;
            return View(model);
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
