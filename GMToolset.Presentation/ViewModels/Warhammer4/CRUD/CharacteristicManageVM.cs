﻿using GMToolset.Services.Models.Warhammer4.Character;
using System.ComponentModel.DataAnnotations;

namespace GMToolset.Presentation.ViewModels.Warhammer4.CRUD
{
    public class CharacteristicManageVM
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ContentPl { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string ContentEng { get; set; } = string.Empty;

        public IEnumerable<Characteristic>? Characteristics { get; set; }
    }
}
