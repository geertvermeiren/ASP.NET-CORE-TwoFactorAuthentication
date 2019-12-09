using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QRCODE_TWOFACTOR.Models;

[assembly: HostingStartup(typeof(QRCODE_TWOFACTOR.Areas.Identity.IdentityHostingStartup))]
namespace QRCODE_TWOFACTOR.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<QRCODE_TWOFACTORContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("QRCODE_TWOFACTORContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<QRCODE_TWOFACTORContext>();
            });
        }
    }
}