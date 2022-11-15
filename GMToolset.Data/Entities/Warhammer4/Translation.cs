using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.Warhammer4
{
    public class Translation
    {
        [Key]
        public Guid Id { get; set; }

        
        [Required]
        [MaxLength(255)]
        public string ContentPl { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string ContentEng { get; set; }
    }
}
