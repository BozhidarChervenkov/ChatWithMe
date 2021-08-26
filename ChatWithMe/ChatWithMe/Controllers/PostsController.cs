namespace ChatWithMe.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using ChatWithMe.ViewModels.Posts;
    using ChatWithMe.Services.Posts;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class PostsController : Controller
    {
        private readonly IPostsService postsService;

        public PostsController(IPostsService postService)
        {
            this.postsService = postService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostFormModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View("Error");
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await this.postsService.Create(input, userId);

            return this.View();
        }
    }
}
