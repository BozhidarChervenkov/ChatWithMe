namespace ChatWithMe.Models
{
    using System;

    public class FriendRequest
    {
        public int Id { get; set; }

        public string FromUserId { get; set; }

        public ApplicationUser FromUser { get; set; }

        public string ToUserId { get; set; }

        public ApplicationUser ToUser { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
