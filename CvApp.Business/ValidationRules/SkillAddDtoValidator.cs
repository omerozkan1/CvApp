using CvApp.DTO.DTOs.SkillDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    public class SkillAddDtoValidator : AbstractValidator<SkillAddDto>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
