namespace ChatWithMe.ViewModels.Posts
{
    using System.Collections.Generic;

    public class AllPostsViewModel
    {
        public IEnumerable<PostInListViewModel> Posts { get; set; }

        public string CustomPofilePicture { get; set; }
    }
}
