namespace ChatWithMe.Models
{
    public class Friend
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserFriendId { get; set; }

        public ApplicationUser UserFriend { get; set; }
    }
}
