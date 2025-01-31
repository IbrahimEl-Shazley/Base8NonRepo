﻿using BaseProject.Domain.Common.Helpers.Validation;
using BaseProject.Domain.Constants;
using BaseProject.Domain.Enums;
using BaseProject.Services.Api.Contract.General;
using FluentValidation;
using System.ComponentModel;

namespace BaseProject.Services.DTO.AuthApiDTO
{
    public class LoginDto
    {
        [DisplayName("رقم الجوال")] public string Phone { get; set; }
        [DisplayName("كلمة المرور")] public string Password { get; set; }
        [DisplayName("الجهاز")] public DeviceDto Device { get; set; }
    }

    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator(IUserContext userContext)
        {
            var lang = userContext.APILang;
            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage(x => FluentValidationHelper.Message<LoginDto>(lang,
                    DefaultPath.ValidationLocalizationPath, nameof(x.Phone), ValidationTypesEnum.Required))
                .Matches(RegEx.SaudiPhone)
                .WithMessage(x => FluentValidationHelper.Message<LoginDto>(lang,
                    DefaultPath.ValidationLocalizationPath, nameof(x.Phone), ValidationTypesEnum.SaudiPhone));

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage(x => FluentValidationHelper.Message<LoginDto>(lang,
                    DefaultPath.ValidationLocalizationPath, nameof(x.Password), ValidationTypesEnum.Required))
                .MinimumLength(6)
                .WithMessage(x => FluentValidationHelper.Message<LoginDto>(lang,
                    DefaultPath.ValidationLocalizationPath, nameof(x.Password), ValidationTypesEnum.MinLength, 6));
        }
    }
}