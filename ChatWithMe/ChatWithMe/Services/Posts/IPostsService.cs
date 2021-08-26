namespace ChatWithMe.Services.Posts
{
    using System.Threading.Tasks;

    using ChatWithMe.ViewModels.Posts;

    public interface IPostsService
    {
         Task<bool> Create(PostFormModel input, string userId);
    }
}
