using CvApp.DTO.DTOs.ExperienceDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    public class ExperienceUpdateDtoValidator : AbstractValidator<ExperienceUpdateDto>
    {
        public ExperienceUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
        }
    }
}
