namespace ChatWithMe.Models
{
    public class FriendRequestToUser
    {
        public int Id { get; set; }

        public string ApllicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
