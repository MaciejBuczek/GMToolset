using GMToolset.Data;
using GMToolset.Data.Entities.Warhammer4.Character.Skills;
using GMToolset.Data.Repositories;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Data.Repositories.Warhammer4;
using GMToolset.Data.Repositories.Warhammer4.Character;
using GMToolset.Data.Repositories.Warhammer4.Character.Skills;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.Warhammer4.Character.Skills;
using GMToolset.Services.Services;
using GMToolset.Services.Services.Model_Services.QuickBattleManager;
using GMToolset.Services.Services.Model_Services.Warhammer4;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

using _Entities = GMToolset.Data.Entities;
using _EntitiesWh4 = GMToolset.Data.Entities.Warhammer4;
using _Models = GMToolset.Services.Models;
using _ModelsWh4 = GMToolset.Services.Models.Warhammer4;

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
            //Wh4
            builder.Services.AddTransient<IModelService<_ModelsWh4.Translation>, TranslationService>();
            builder.Services.AddTransient<IModelService<_ModelsWh4.Character.CharacterSheet>, CharacterSheetService>();
            builder.Services.AddTransient<IModelService<_ModelsWh4.Character.Characteristic>, CharacteristicService>();
            builder.Services.AddTransient<IModelService<_ModelsWh4.Character.Skills.Skill>, SkillService>();

            //Sessions
            builder.Services.AddTransient<IModelService<_Models.QuickBattleManager.Participant>, ParticipantService>();
            builder.Services.AddTransient<IModelService<_Models.QuickBattleManager.QuickSession>, QuickSessionService>();

            //Data
            //Wh4
            builder.Services.AddTransient<IRepository<_EntitiesWh4.Translation>, TranslationRepository>();
            builder.Services.AddTransient<IRepository<_EntitiesWh4.Character.CharacterSheet>, CharacterSheetRepository>();
            builder.Services.AddTransient<IRepository<_EntitiesWh4.Character.Characteristic>, CharacteristicRepository>();
            builder.Services.AddTransient<IRepository<_EntitiesWh4.Character.Skills.Skill>, SkillRepository>();
            builder.Services.AddTransient<IRepository<_EntitiesWh4.Character.Skills.SkillType>, SkillTypeRepository>();

            //Sessions
            builder.Services.AddTransient<IRepository<_Entities.QuickBattleManager.Participant>, ParticipantRepository>();
            builder.Services.AddTransient<IRepository<_Entities.QuickBattleManager.QuickSession>, QuickSessionRepository>();
        }
    }
}
