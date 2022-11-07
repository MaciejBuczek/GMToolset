using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.Warhammer4;
using GMToolset.Services.Services.Model_Services.Warhammer4;
using Microsoft.AspNetCore.Mvc;

namespace GMToolset.Presentation.Controllers
{
    public class CharacterController : Controller
    {
        private readonly IModelService<CharacterSheet> _characterSheetService;

        public CharacterController(IModelService<CharacterSheet> characterSheetService)
        {
            _characterSheetService = characterSheetService;
        }

        public IActionResult CharacterSheet()
        {
            var characterSheet = _characterSheetService.GetAll().FirstOrDefault();
            return View(characterSheet);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            _characterSheetService.Add(new CharacterSheet()
            {
                Name = "Stary Cap",
                Species = "Człowiek",
                Class = "Pospólstwo",
                Career = "Górnik",
                CareerPath = String.Empty,
                CarrierTier = "Mistrz Górnictwa",
                Status = "bronze 1",
                Age = "71",
                Height = "161",
                Hair = "None",
                Eyes = "Brown",
                WeaponSkill  = 20,
                WeaponSkillAdv = 5,
                BallisticSkill = 15, 
                BallisticSkillAdv = 0,
                Strength = 30,
                StrengthAdv = 5, 
                Toughness = 32, 
                ToughnessAdv = 5,
                Initiattive = 15,
                InitiattiveAdv = 0,
                Agility = 20,
                AgilityAdv = 2,
                Dexterity = 20, 
                DexterityAdv = 5,
                Intelligence = 15,
                IntelligenceAdv = 0,
                Willpower = 15, 
                WillpowerAdv = 5,
                Fellowship = 35,
                FellowshipAdv = 10,
                Wounds  = 9,
                Fate = 2, 
                Fortune = 2,
                Resilience = 1,
                Resolve =1,
                Motivation = String.Empty,
                ExpCurrent = 0,
                ExpSpent = 0,
                Movement = 2
                });

            return Ok();
        }
    }
}
