using CvApp.DTO.DTOs.SocialMediaIconDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    public class SocialMediaIconAddDtoValidator : AbstractValidator<SocialMediaIconAddDto>
    {
        public SocialMediaIconAddDtoValidator()
        {
            RuleFor(x => x.AppUserId).InclusiveBetween(1, int.MaxValue).WithMessage("AppUserId alanı boş bırakılamaz");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("İkon alanı boş bırakılamaz");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Link alanı boş bırakılamaz");
        }
    }
}
