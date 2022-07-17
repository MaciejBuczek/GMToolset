using AutoMapper;
using GMToolset.Data;
using GMToolset.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GMToolset.Presentation.Configs
{
    public class DependencyInjectionBuilder
    {
        public void AddDependencies(WebApplicationBuilder builder)
        {
            //Database context setup
            var connectionString = builder.Environment.IsDevelopment() ?
                builder.Configuration.GetConnectionString("Local") :
                new UrlConnectionStringParser().GetConnectionString(Environment.GetEnvironmentVariable("DATABASE_URL"));
            builder.Services.AddDbContext<AppDbContext>(
                    o => o.UseNpgsql(connectionString)
                );

            //Email sender setup
            builder.Services.AddTransient<IEmailSender, EmailSender>();
            builder.Services.Configure<AuthMessageSenderOptions>(o =>
            o.SendGridKey = Environment.GetEnvironmentVariable("SENDGRIDKEY"));

            builder.Services.Configure<DataProtectionTokenProviderOptions>(o =>
                   o.TokenLifespan = TimeSpan.FromHours(2));

            //Automapper setup
            builder.Services.AddAutoMapper(Assembly.GetAssembly(this.GetType()));
        }
    }
}
