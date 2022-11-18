using GMToolset.Presentation.ViewModels.Warhammer4.CRUD;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.Warhammer4;
using GMToolset.Services.Models.Warhammer4.Character.Skills;
using Microsoft.AspNetCore.Mvc;

namespace GMToolset.Presentation.Controllers
{
    public class SkillTypeController : Controller
    {
        private readonly IModelService<SkillType> _skillTypeService;

        public SkillTypeController(IModelService<SkillType> skillTypeService)
        {
            _skillTypeService = skillTypeService;
        }

        [HttpGet]
        public IActionResult Manage()
        {
            var vm = new TranslationBasedManageVM<SkillType>
            {
                ContentEng = String.Empty,
                ContentPl = String.Empty,
                Entries = _skillTypeService.GetAll()
            };
            ModelState.Clear();
            return View(vm);
        }

        [HttpGet]
        public IActionResult ManageResult(TranslationBasedManageVM<SkillType> vm)
        {
            return View(nameof(Manage), vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(TranslationBasedManageVM<SkillType> vm)
        {
            if (ModelState.IsValid)
            {
                var skillType = new SkillType
                {
                    Name = new Translation
                    {
                        ContentPl = vm.ContentPl,
                        ContentEng = vm.ContentEng
                    }
                };
                _skillTypeService.Add(skillType);
                return RedirectToAction(nameof(Manage));

            }
            return RedirectToAction(nameof(ManageResult), vm);
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public IActionResult Remove([FromBody] string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            if (_skillTypeService.GetById(Guid.Parse(id)) != null)
            {
                _skillTypeService.Delete(Guid.Parse(id));
                return Ok();
            }

            return NotFound();
        }

        [HttpPatch]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromBody] TranslationBasedManageVM<SkillType> vm)
        {
            if (vm == null || vm.Id == Guid.Empty)
                return BadRequest();

            var characteristic = new SkillType
            {
                Id = vm.Id,
                Name = new Translation
                {
                    ContentPl = vm.ContentPl,
                    ContentEng = vm.ContentEng
                }
            };
            _skillTypeService.Update(characteristic);

            return Ok();
        }
    }
}
