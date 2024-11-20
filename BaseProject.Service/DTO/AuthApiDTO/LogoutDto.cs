using BaseProject.Domain.Common.Helpers.Validation;
using BaseProject.Domain.Constants;
using BaseProject.Domain.Enums;
using BaseProject.Services.Api.Contract.General;
using FluentValidation;

namespace BaseProject.Services.DTO.AuthApiDTO;

public class LogoutDto
{
    public string DeviceId { get; set; }
}

public class LogoutDtoValidator : AbstractValidator<LogoutDto>
{
    public LogoutDtoValidator(IUserContext userContext)
    {
        var lang = userContext.APILang;
        RuleFor(x => x.DeviceId)
            .NotEmpty()
            .WithMessage(x => FluentValidationHelper.Message<LogoutDto>(lang,
                DefaultPath.ValidationLocalizationPath, nameof(x.DeviceId), ValidationTypesEnum.Required));
    }
}