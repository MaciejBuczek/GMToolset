using GMToolset.Presentation.ViewModels.Warhammer4;
using GMToolset.Presentation.ViewModels.Warhammer4.CRUD;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.Warhammer4;
using GMToolset.Services.Models.Warhammer4.Character;
using Microsoft.AspNetCore.Mvc;

namespace GMToolset.Presentation.Controllers
{
    public class CharacteristicController : Controller
    {
        private readonly IModelService<Characteristic> _characteristicService;

        public CharacteristicController(IModelService<Characteristic> characteristicService)
        {
            _characteristicService = characteristicService;
        }

        public IActionResult Manage(TranslationCRUD translationCRUD)
        {
            var a = ModelState.ErrorCount;
            var vm = new CharacteristicManageVM
            {
                Characteristics = _characteristicService.GetAll(),
                TranslationCRUD =  translationCRUD ?? new TranslationCRUD()
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(TranslationCRUD translationCRUD)        
        {
            if (ModelState.IsValid)
            {
                var characteristic = new Characteristic
                {
                    Name = new Translation
                    {
                        ContentPl = translationCRUD.ContentPl,
                        ContentEng = translationCRUD.ContentEng
                    }
                };
                _characteristicService.Add(characteristic);
            }
            return RedirectToAction(nameof(Manage), translationCRUD);
        }
    }
}
