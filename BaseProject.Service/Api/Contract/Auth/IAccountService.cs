using BaseProject.Services.DTO;
using BaseProject.Services.DTO.AuthApiDTO;

namespace BaseProject.Services.Api.Contract.Auth;

public interface IAccountService
{
    Task<Result<bool>> Register(RegisterDto dto);
    Task<Result<bool>> ResendCode(ResendCodeDto dto);

    Task<Result<bool>> ConfirmCode(ConfirmCodeDto confirmCodeDto);
    Task<Result<UserInfoDto>> Login(LoginDto dto);


    Task<Result<bool>> ChangePassword(ChangePasswordDto input);

    Task<Result<bool>> ResetPassword(ResetPasswordDto resetPasswordDto);

    /*
    Task<BaseResponse<ConfirmCodeByPhone>> CheckPhone(string currentPassword, string newPhone, string userId, string lang);
    Task<BaseResponse<string>> ChangeLanguage(string lang, string userId);
    */
    Task<Result<bool>> Logout(LogoutDto userModel);
    Task<Result<bool>> RemoveAccount();
}