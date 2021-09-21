namespace ChatWithMe.Services.Chats
{
    using System.Linq;

    using ChatWithMe.Data;
    
    public class ChatsService : IChatsService
    {
        private readonly ApplicationDbContext context;

        public ChatsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public string FirstAndLastName(string userName)
        {
            var user = this.context.Users.FirstOrDefault(u=>u.UserName == userName);
            var formattedName = user.FirstName + " " + user.LastName;

            return formattedName;
        }
    }
}
