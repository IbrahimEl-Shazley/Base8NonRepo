using BaseProject.Domain.Common.Helpers.Validation;
using BaseProject.Domain.Constants;
using BaseProject.Domain.Enums;
using BaseProject.Services.Api.Contract.General;
using FluentValidation;
using System.ComponentModel;


namespace BaseProject.Services.DTO.AuthApiDTO;

public class ResendCodeDto
{
    [DisplayName("رقم الجوال")] public string PhoneNumber { get; set; }
}

public class ResendCodeDtoValidator : AbstractValidator<ResendCodeDto>
{
    public ResendCodeDtoValidator(IUserContext userContext)
    {
        var lang = userContext.APILang;
        RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage(x => FluentValidationHelper.Message<ResendCodeDto>(lang,
                DefaultPath.ValidationLocalizationPath, nameof(x.PhoneNumber), ValidationTypesEnum.Required))
            .Matches(RegEx.SaudiPhone)
            .WithMessage(x => FluentValidationHelper.Message<ResendCodeDto>(lang, DefaultPath.ValidationLocalizationPath,
                nameof(x.PhoneNumber), ValidationTypesEnum.SaudiPhone));
    }
}