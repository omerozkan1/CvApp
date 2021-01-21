using CvApp.DTO.DTOs.InterestDtos;
using FluentValidation;


namespace CvApp.Business.ValidationRules
{
    public class InterestUpdateDtoValidator : AbstractValidator<InterestUpdateDto>
    {
        public InterestUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
        }
    }
}
