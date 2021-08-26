namespace ChatWithMe.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using ChatWithMe.ViewModels.Posts;
    using ChatWithMe.Services.Posts;
    
    public class PostsController : Controller
    {
        private readonly IPostsService postsService;

        public PostsController(IPostsService postService)
        {
            this.postsService = postService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(PostFormModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View("Error");
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await this.postsService.Create(input, userId);

            return this.RedirectToAction("All");
        }

        [HttpGet]
        public IActionResult All()
        {
            var postsAsList = this.postsService.All();

            return this.View(postsAsList);
        }
    }
}
