using CvApp.DTO.DTOs.ExperienceDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    public class ExperienceAddDtoValidator : AbstractValidator<ExperienceAddDto>
    {
        public ExperienceAddDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz");
            RuleFor(x=> x.SubTitle).NotEmpty().WithMessage("Alt başlık alanı boş bırakılamaz");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz");
        }
    }
}
