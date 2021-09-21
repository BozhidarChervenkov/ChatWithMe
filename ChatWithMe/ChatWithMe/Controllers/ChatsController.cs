namespace ChatWithMe.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    [Authorize]
    public class ChatsController : Controller
    {
        public IActionResult GroupChat()
        {
            return this.View();
        }
    }
}
