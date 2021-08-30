namespace ChatWithMe.Services.Posts
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using ChatWithMe.Data;
    using ChatWithMe.Models;
    using ChatWithMe.ViewModels.Posts;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;

    public class PostsService : IPostsService
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<ApplicationUser> userManager;

        public PostsService(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment, UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
            this.userManager = userManager;
        }

        public async Task<bool> Create(PostFormModel input, string userId)
        {
            string stringFileName = UploadFile(input);

            var post = new Post
            {
                TextTitle = input.TextTitle,
                TextContent = input.TextContent,
                CreatedOn = DateTime.Now,
                IsDeleted = false,
                PostedByUserId = userId,
                PostImage = stringFileName
            };

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();

            return true;
        }
        
        public async Task<AllPostsViewModel> All(string userId)
        {
            var posts = this.context.Posts
                .Where(p=> p.IsDeleted == false)
                .Select(p => new PostInListViewModel()
                {
                    Id = p.Id,
                    TextTitle = p.TextTitle,
                    TextContent = p.TextContent,
                    PostImage = p.PostImage,
                    CustomPofilePicture = p.PostedByUser.CustomPofilePicture,
                    PostedByUserId = p.PostedByUserId,
                    PostedByUser = p.PostedByUser,
                    CreatedOn = p.CreatedOn
                })
                .ToList();

            var user = await this.userManager.FindByIdAsync(userId);

            var postsAsList = new AllPostsViewModel()
            {
                Posts = posts
            };

            return postsAsList;
        }

        private string UploadFile(PostFormModel input)
        {
            string fileName = String.Empty;

            if (input.PostImage != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "PostsImages");
                fileName = Guid.NewGuid().ToString() + "-" + input.PostImage.FileName;
                string filePath = Path.Combine(uploadDir, fileName);

                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    input.PostImage.CopyTo(filestream);
                }
            }

            return fileName;
        }
    }
}
