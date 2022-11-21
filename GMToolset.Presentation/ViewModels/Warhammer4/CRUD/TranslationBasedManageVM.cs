using System.ComponentModel.DataAnnotations;

namespace GMToolset.Presentation.ViewModels.Warhammer4.CRUD
{
    public class TranslationBasedManageVM<T>
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ContentPl { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string ContentEng { get; set; } = string.Empty;

        public IEnumerable<T>? Entries { get; set; }
    }
}
