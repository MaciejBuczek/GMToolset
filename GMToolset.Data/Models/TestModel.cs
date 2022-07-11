using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Models
{
    public class TestModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
