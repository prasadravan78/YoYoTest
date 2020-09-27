namespace Yo_Yo_Test.Web.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using YoYoTest.DomainServices.AtheleteService;
    using YoYoTest.Web.ViewModels;

    /// <summary>
    /// Provides functionality to display Home Page.
    /// </summary>
    public class HomeController : Controller
    {
        #region Member Variables

        private readonly IAtheleteService atheleteService;

        #endregion Member Variables

        #region Constructors

        /// <summary>
        /// Sets various dependencies.
        /// </summary>
        public HomeController(IAtheleteService atheleteService)
        {
            this.atheleteService = atheleteService;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Displays Home page.
        /// </summary>
        /// <returns>Index view</returns>
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Atheletes = atheleteService.GetAtheletes()
            };

            return View(homeViewModel);
        }

        #endregion Public Methods
    }
}
