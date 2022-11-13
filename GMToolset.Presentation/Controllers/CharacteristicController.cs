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

        [HttpGet]
        public IActionResult Manage()
        {
            var vm = new CharacteristicManageVM
            {
                ContentEng = String.Empty,
                ContentPl = String.Empty,
                Characteristics = _characteristicService.GetAll()
            };
            ModelState.Clear();
            return View(vm);
        }

        [HttpGet]
        public IActionResult ManageResult(CharacteristicManageVM vm)
        {
            return View(nameof(Manage), vm);
        }

        [HttpPost]
        public IActionResult Add(CharacteristicManageVM vm)        
        {
            if (ModelState.IsValid)
            {
                var characteristic = new Characteristic
                {
                    Name = new Translation
                    {
                        ContentPl = vm.ContentPl,
                        ContentEng = vm.ContentEng
                    }
                };
                _characteristicService.Add(characteristic);
                return RedirectToAction(nameof(Manage));

            }
            return RedirectToAction(nameof(ManageResult), vm);
        }
    }
}
