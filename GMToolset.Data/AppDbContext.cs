using GMToolset.Data.Entities.BattleManager;
using GMToolset.Data.Entities.Warhammer4;
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
        public DbSet<Participant> Participant { get; set; }
        public DbSet<QuickSession> QuickSessions { get; set; }

    }
}
