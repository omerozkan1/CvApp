using CvApp.DTO.DTOs.EducationDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    public class EducationAddDtoValidator : AbstractValidator<EducationAddDto>
    {
        public EducationAddDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Alt başlık alanı boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");
        }
    }
}
