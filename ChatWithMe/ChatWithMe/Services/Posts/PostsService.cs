namespace ChatWithMe.Services.Posts
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using ChatWithMe.Data;
    using ChatWithMe.Models;
    using ChatWithMe.ViewModels.Posts;
    using Microsoft.AspNetCore.Hosting;

    public class PostsService : IPostsService
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public PostsService(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<bool> Create(PostFormModel input, string userId)
        {
            string stringFileName = UploadFile(input);

            var post = new Post
            {
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
