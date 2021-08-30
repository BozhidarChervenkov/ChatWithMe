namespace ChatWithMe.Controllers
{   
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using ChatWithMe.Services.Profiles;
    using System.Security.Claims;

    public class ProfilesController : Controller
    {
        private readonly IProfilesService profilesService;

        public ProfilesController(IProfilesService profilesService)
        {
            this.profilesService = profilesService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Mine()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var viewModel = this.profilesService.ProfileInfo(userId);

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }
    }
}
