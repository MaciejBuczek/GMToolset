using GMToolset.Data;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Data.Repositories.Warhammer4;
using GMToolset.Data.Repositories.Warhammer4.Character;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Services;
using GMToolset.Services.Services.Model_Services.Warhammer4;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

using _Entities = GMToolset.Data.Entities.Warhammer4;
using _Models = GMToolset.Services.Models.Warhammer4;

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
            builder.Services.AddTransient<IModelService<_Models.Translation>, TranslationService>();
            builder.Services.AddTransient<IModelService<_Models.Character.CharacterSheet>, CharacterSheetService>();
            builder.Services.AddTransient<IModelService<_Models.Character.Characteristic>, CharacteristicService>();
            builder.Services.AddTransient<IModelService<_Models.Character.Skill>, SkillService>();

            //Data
            builder.Services.AddTransient<IRepository<_Entities.Translation>, TranslationRepository>();
            builder.Services.AddTransient<IRepository<_Entities.Character.CharacterSheet>, CharacterSheetRepository>();
            builder.Services.AddTransient<IRepository<_Entities.Character.Characteristic>, CharacteristicRepository>();
            builder.Services.AddTransient<IRepository<_Entities.Character.Skill>, SkillRepository>();

        }
    }
}
