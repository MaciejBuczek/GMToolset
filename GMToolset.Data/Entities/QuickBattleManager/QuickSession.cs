using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.QuickBattleManager
{
    public class QuickSession
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TimeSpan LastUpdate { get; set; }
    }
}
