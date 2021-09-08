namespace ChatWithMe.Controllers
{
    using System.Diagnostics;
    using System.Security.Claims;
    using Microsoft.AspNetCore.Mvc;

    using ChatWithMe.Models;
    using ChatWithMe.Services.Home;

    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        public IActionResult Index()
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var viewModel = this.homeService.Users(currentUserId);

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
