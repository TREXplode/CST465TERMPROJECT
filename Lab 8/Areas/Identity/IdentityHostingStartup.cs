using System;
using Lab8Identity.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Lab8Identity.Areas.Identity.IdentityHostingStartup))]
namespace Lab8Identity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Lab8IdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Lab8IdentityContextConnection")));

                services.AddIdentity<UserModel, IdentityRole>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = true;
                    options.Password.RequiredLength = 3;
                    options.Password.RequiredUniqueChars = 1;
                })
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<Lab8IdentityContext>();
            });
        }
    }
}