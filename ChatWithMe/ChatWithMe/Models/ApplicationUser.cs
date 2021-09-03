namespace ChatWithMe.Models
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Friends = new HashSet<Friend>();
            this.FriendRequests = new HashSet<FriendRequest>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string CustomPofilePicture { get; set; }

        public ICollection<Friend> Friends { get; set; }

        public ICollection<FriendRequest> FriendRequests { get; set; }
    }
}
