namespace Yo_Yo_Test.Web.Controllers
{
    using System;
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using YoYoTest.Web.Models;

    public class HomeController : Controller
    {
        #region Member Variables

        #endregion Member Variables

        #region Constructors

        public HomeController()
        {

        }

        #endregion Constructors

        #region Public Methods

        public IActionResult Index()
        {

            return View();
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

        #endregion Public Methods
    }
}
