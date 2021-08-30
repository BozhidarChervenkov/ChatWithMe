﻿namespace ChatWithMe.Models
{
    public class FriendRequestFromUser
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ApllicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}