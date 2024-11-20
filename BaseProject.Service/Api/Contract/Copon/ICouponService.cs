using BaseProject.Services.DTO;
using BaseProject.Services.DTO.CouponDto;

namespace BaseProject.Services.Api.Contract.Copon
{
    public interface ICouponService
    {
        Task<Result<CouponDto>> UseCouponByUser(UseCouponDto useCouponDto, string userId, string lang = "ar");
        Task<CopounValidationDto> ValidateCopoun(string copounCode, string userId, string lang = "ar");
        Task<CouponDto> GetLastTotalForUsingCoupon(string couponCode, double total);
    }
}
