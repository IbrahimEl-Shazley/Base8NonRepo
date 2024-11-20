using Microsoft.AspNetCore.Http;

namespace BaseProject.Services.DTO.DashbordDTO.AppApiDTO
{
    public class AdvertismentsAddApiDto
    {
        public string TitelAr { get; set; }
        public string TitelEn { get; set; }
        public int Type { get; set; }
        public IFormFile ImgFile { get; set; }
    }
}
