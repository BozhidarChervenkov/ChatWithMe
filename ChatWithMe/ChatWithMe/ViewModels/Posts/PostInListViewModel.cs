namespace ChatWithMe.ViewModels.Posts
{
    using System;

    using ChatWithMe.Models; 

    public class PostInListViewModel
    {
        public int Id { get; set; }

        public string TextTitle{ get; set; }

        public string TextContent { get; set; }

        public string PostedByUserId { get; set; }

        public ApplicationUser PostedByUser { get; set; }

        public string PostImage { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
