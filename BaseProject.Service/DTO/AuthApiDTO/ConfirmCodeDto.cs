using BaseProject.Domain.Common.Helpers.Validation;
using BaseProject.Domain.Constants;
using BaseProject.Domain.Enums;
using BaseProject.Services.Api.Contract.General;
using FluentValidation;
using System.ComponentModel;

namespace BaseProject.Services.DTO.AuthApiDTO;

public class ConfirmCodeDto
{
    [DisplayName("رقم الجوال")] public string PhoneNumber { get; set; }

    [DisplayName("كود التحقق")] public int Code { get; set; }
}

public class ConfirmCodeDtoValidator : AbstractValidator<ConfirmCodeDto>
{
    public ConfirmCodeDtoValidator(IUserContext userContext)
    {
        var lang = userContext.APILang;

        RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage(x => FluentValidationHelper.Message<ConfirmCodeDto>(lang,
                DefaultPath.ValidationLocalizationPath, nameof(x.PhoneNumber), ValidationTypesEnum.Required))
            .Matches(RegEx.SaudiPhone)
            .WithMessage(x => FluentValidationHelper.Message<ConfirmCodeDto>(lang,
                DefaultPath.ValidationLocalizationPath,
                nameof(x.PhoneNumber), ValidationTypesEnum.SaudiPhone));

        RuleFor(x => x.Code)
            .NotEmpty().WithMessage(x => FluentValidationHelper.Message<ConfirmCodeDto>(lang,
                DefaultPath.ValidationLocalizationPath, nameof(x.Code), ValidationTypesEnum.Required));
    }
}