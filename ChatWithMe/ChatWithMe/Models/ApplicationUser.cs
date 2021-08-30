namespace ChatWithMe.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Friends = new HashSet<Friend>();
            this.FriendRequestsFromUser = new HashSet<FriendRequestFromUser>();
            this.FriendRequestsToUser = new HashSet<FriendRequestToUser>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string CustomPofilePicture { get; set; }

        public ICollection<Friend> Friends { get; set; }

        public ICollection<FriendRequestFromUser> FriendRequestsFromUser { get; set; }

        public ICollection<FriendRequestToUser> FriendRequestsToUser { get; set; }
    }
}
