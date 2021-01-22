using CvApp.DTO.DTOs.AppUserDtos;
using FluentValidation;

namespace CvApp.Business.ValidationRules
{
    class AppUserPasswordDtoValidator : AbstractValidator<AppUserPasswordDto>
    {
        public AppUserPasswordDtoValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Parola tekrar alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Parolalar uyuşmuyor");
        }
    }
}
