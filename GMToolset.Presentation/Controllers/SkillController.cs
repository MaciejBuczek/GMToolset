using GMToolset.Presentation.ViewModels.Warhammer4.CRUD;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.Warhammer4;
using GMToolset.Services.Models.Warhammer4.Character;
using GMToolset.Services.Models.Warhammer4.Character.Skills;
using Microsoft.AspNetCore.Mvc;

namespace GMToolset.Presentation.Controllers
{
    public class SkillController : Controller
    {
        private readonly IModelService<Characteristic> _characteristicService;
        private readonly IModelService<Skill> _skillService;
        private readonly IModelService<SkillType> _skillTypeService;


        public SkillController( IModelService<Skill> skillService, IModelService<SkillType> skillTypeService, IModelService<Characteristic> characteristicService)
        {
            _skillService = skillService;
            _skillTypeService = skillTypeService;
            _characteristicService = characteristicService;
        }

        [HttpGet]
        public IActionResult Manage()
        {
            var vm = new SkillManageVM
            {
                ContentEng = String.Empty,
                ContentPl = String.Empty,
                Characteristics = _characteristicService.GetAll(),
                Skills = _skillService.GetAll(),
                SkillTypes = _skillTypeService.GetAll()
            };
            ModelState.Clear();
            return View(vm);
        }

        //[HttpGet]
        //public IActionResult ManageResult(SkillManageVM vm)
        //{
        //    return View(nameof(Manage), vm);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(SkillManageVM vm)
        {
            if (ModelState.IsValid)
            {
                var skill = new Skill
                {
                    Name = new Translation
                    {
                        ContentPl = vm.ContentPl,
                        ContentEng = vm.ContentEng
                    },
                    SkillTypeId= vm.SkillTypeId,
                    CharacteristicId= vm.CharacteristicId
                    
                };
                _skillService.Add(skill);
                return RedirectToAction(nameof(Manage));

            }
            return RedirectToAction(nameof(vm), vm);
        }

        //[HttpDelete]
        //[ValidateAntiForgeryToken]
        //public IActionResult Remove([FromBody] string id)
        //{
        //    if (string.IsNullOrEmpty(id))
        //        return BadRequest();

        //    if (_characteristicService.GetById(Guid.Parse(id)) != null)
        //    {
        //        _characteristicService.Delete(Guid.Parse(id));
        //        return Ok();
        //    }

        //    return NotFound();
        //}

        //[HttpPatch]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit([FromBody] CharacteristicManageVM vm)
        //{
        //    if (vm == null || vm.Id == Guid.Empty)
        //        return BadRequest();

        //    var characteristic = new Characteristic
        //    {
        //        Id = vm.Id,
        //        Name = new Translation
        //        {
        //            ContentPl = vm.ContentPl,
        //            ContentEng = vm.ContentEng
        //        }
        //    };
        //    _characteristicService.Update(characteristic);

        //    return Ok();
        //}
    }
}
