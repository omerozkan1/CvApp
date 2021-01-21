using CvApp.DTO.DTOs.SocialMediaIconDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    public class SocialMediaIconUpdateDtoValidator : AbstractValidator<SocialMediaIconUpdateDto>
    {
        public SocialMediaIconUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş bırakılamaz");
            RuleFor(x => x.AppUserId).InclusiveBetween(1, int.MaxValue).WithMessage("AppUserId alanı boş bırakılamaz");
        }
    }
}
