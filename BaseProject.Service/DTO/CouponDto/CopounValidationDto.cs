using BaseProject.Domain.Entities.Copon;

namespace BaseProject.Services.DTO.CouponDto
{
    public class CopounValidationDto
    {
        public Result<string> Result { get; set; }
        public Copon Copoun { get; set; }
    }
}
