namespace ChatWithMe.Hubs
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.AspNetCore.Authorization;

    using ChatWithMe.Models;
    using ChatWithMe.Services.Chats;

    [Authorize]
    public class ChatHub : Hub
    {
        private readonly IChatsService chatsService;

        public ChatHub(IChatsService chatsService)
        {
            this.chatsService = chatsService;
        }

        public async Task Send(string message)
        {
            await this.Clients.All.SendAsync(
                "NewMessage",
                new Message { User = this.chatsService.FirstAndLastName(this.Context.User.Identity.Name), Text = message, });
        }
    }
}
