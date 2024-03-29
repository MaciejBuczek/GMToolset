﻿using GMToolset.Data.Entities.QuickBattleManager;
using GMToolset.Data.Entities.Warhammer4;
using GMToolset.Data.Entities.Warhammer4.Character;
using GMToolset.Data.Entities.Warhammer4.Character.Skills;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GMToolset.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CharacterSheet> CharacterSheets { get; set; }

        public DbSet<Characteristic> Characteristics { get; set; }

        public DbSet<CharacterCharacteristics> CharacterCharacteristics { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SkillType> SkillTypes { get; set; }

        public DbSet<CharacterSkills> CharacterSkills { get; set; }

        public DbSet<Translation> Translations { get; set; }

        public DbSet<Participant> Participant { get; set; }

        public DbSet<QuickSession> QuickSessions { get; set; }

    }
}
