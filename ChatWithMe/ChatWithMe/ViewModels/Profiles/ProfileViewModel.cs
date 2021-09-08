namespace ChatWithMe.ViewModels.Profiles
{
    using System.Collections.Generic;

    using ChatWithMe.Models;

    public class ProfileViewModel
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string CustomPofilePicture { get; set; }

        public bool IsUserFriend { get; set; }

        public ICollection<Friend> Friends { get; set; }

        public ICollection<FriendRequest> FriendRequests { get; set; }
    }
}
