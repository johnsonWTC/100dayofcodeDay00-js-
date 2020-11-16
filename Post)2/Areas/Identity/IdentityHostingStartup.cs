using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Post_2.Areas.Identity.Data;
using Post_2.Data;

[assembly: HostingStartup(typeof(Post_2.Areas.Identity.IdentityHostingStartup))]
namespace Post_2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Post_2Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Post_2ContextConnection")));

                services.AddDefaultIdentity<Post_2User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Post_2Context>();
            });
        }
    }
}