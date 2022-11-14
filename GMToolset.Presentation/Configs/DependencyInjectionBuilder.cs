using GMToolset.Data;
using GMToolset.Data.Repositories;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Presentation.Helpers.Intefaces;
using GMToolset.Presentation.Helpers.Managers;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Services;
using GMToolset.Services.Services.Model_Services.QuickBattleManager;
using GMToolset.Services.Services.Model_Services.Warhammer4;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using GMTEntities = GMToolset.Data.Entities;
using GMTModels = GMToolset.Services.Models;

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

            //Managers
            builder.Services.AddTransient<IRoleManager, RoleManager>();

            //Services
            builder.Services.AddTransient<IModelService<GMTModels.Warhammer4.CharacterSheet>, CharacterSheetService>();
            builder.Services.AddTransient<IModelService<GMTModels.QuickBattleManager.QuickSession>, QuickSessionService>();
            builder.Services.AddTransient<IModelService<GMTModels.QuickBattleManager.Participant>, ParticipantService>();

            //Data
            builder.Services.AddTransient<IRepository<GMTEntities.Warhammer4.CharacterSheet>, CharacterSheetRepository>();
            builder.Services.AddTransient<IRepository<GMTEntities.QuickBattleManager.QuickSession>, QuickSessionRepository>();
            builder.Services.AddTransient<IRepository<GMTEntities.QuickBattleManager.Participant>, ParticipantRepository>();
        }
    }
}
