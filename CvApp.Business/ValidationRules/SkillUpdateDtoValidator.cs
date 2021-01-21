using CvApp.DTO.DTOs.SkillDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    public class SkillUpdateDtoValidator : AbstractValidator<SkillUpdateDto>
    {
        public SkillUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
        }
    }
}
