using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ChatWithMe.Areas.Identity.IdentityHostingStartup))]
namespace ChatWithMe.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {});
        }
    }
}