namespace ChatWithMe.Controllers
{
    using System.Security.Claims;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using ChatWithMe.Services.Profiles;
    using System.Threading.Tasks;

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
            var viewModel = this.profilesService.MyProfile(userId);

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [Authorize]
        [HttpGet]
        public IActionResult ById(string id)
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var viewModel = this.profilesService.ProfileById(id, currentUserId);

            if (viewModel == null)
            {
                return this.BadRequest();
            }

            return this.View(viewModel);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> SendFriendRequest(string idOfWantedUser)
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            bool isFriendRequestSent = await this.profilesService.AddFriendRequest(currentUserId, idOfWantedUser);

            if (isFriendRequestSent == false)
            {
                return this.BadRequest();
            }

            return this.RedirectToAction("Index", "Home");
        }

        [Authorize]
        [HttpGet]
        public IActionResult SeeFriendRequests(string id)
        {
            var viewModel = this.profilesService.FriendRequests(id);

            return this.View(viewModel);
        }
    }
}
