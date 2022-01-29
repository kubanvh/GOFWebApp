using System;
using GOFWebApp.Areas.Identity.Data;
using GOFWebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GOFWebApp.Areas.Identity.IdentityHostingStartup))]
namespace GOFWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GOFWebAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GOFWebAppContextConnection")));

                services.AddDefaultIdentity<GOFWebAppUser>(options => 
                options.SignIn.RequireConfirmedAccount = false)

                    .AddEntityFrameworkStores<GOFWebAppContext>();
            });
        }
    }
}