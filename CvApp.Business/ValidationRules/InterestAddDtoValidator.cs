using CvApp.DTO.DTOs.InterestDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    class InterestAddDtoValidator : AbstractValidator<InterestAddDto>
    {
        public InterestAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
