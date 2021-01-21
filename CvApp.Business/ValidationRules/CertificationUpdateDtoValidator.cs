using CvApp.DTO.DTOs.CertificationDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    public class CertificationUpdateDtoValidator : AbstractValidator<CertificationUpdateDto>
    {
        public CertificationUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Sertifika boş geçilemez");
        }
    }
}
