using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(UzmanLaundry.Areas.Identity.IdentityHostingStartup))]
namespace UzmanLaundry.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}