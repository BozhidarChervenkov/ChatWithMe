namespace ChatWithMe.ViewModels.Profiles
{
    using ChatWithMe.Models;
    using System.Collections.Generic;

    public class MyProfileViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string CustomPofilePicture { get; set; }

        public ICollection<Friend> Friends { get; set; }

        public ICollection<FriendRequestFromUser> FriendRequestsFromUsers { get; set; }

        public ICollection<FriendRequestToUser> FriendRequestToUsers { get; set; }
    }
}
