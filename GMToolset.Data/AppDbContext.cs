using GMToolset.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GMToolset.Data
{
    public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

        public DbSet<TestModel> TestModels { get; set; }
    }
}
