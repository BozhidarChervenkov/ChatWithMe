namespace ChatWithMe.ViewModels.Profiles
{
    using System;

    using ChatWithMe.Models;
    
    public class FriendRequestViewModel
    {
        public int Id { get; set; }

        public string FromUserFirstName { get; set; }

        public string FromUserLastName { get; set; }

        public string FromUserId { get; set; }

        public string FromUserProfileImage { get; set; }

        public string CurrentUserId { get; set; }

        public ApplicationUser FromUser { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
