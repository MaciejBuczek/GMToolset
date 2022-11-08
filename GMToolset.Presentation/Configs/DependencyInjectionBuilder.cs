using GMToolset.Data;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Data.Repositories.Warhammer4.Character;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.Warhammer4.Character;
using GMToolset.Services.Services;
using GMToolset.Services.Services.Model_Services;
using GMToolset.Services.Services.Model_Services.Warhammer4;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using GMTEntities = GMToolset.Data.Entities.Warhammer4;
using GMTModels = GMToolset.Services.Models.Warhammer4;

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
            var assembly = Assembly.GetAssembly(GetType());
            builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(Services.Data.Constants)));

            //Services
            builder.Services.AddTransient<IModelService<CharacterSheet>, CharacterSheetService>();

            //Data
            builder.Services.AddTransient<IRepository<GMTEntities.Character.CharacterSheet>, CharacterSheetRepository>();
        }
    }
}
