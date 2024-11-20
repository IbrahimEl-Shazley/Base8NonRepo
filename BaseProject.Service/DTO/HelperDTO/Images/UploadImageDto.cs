using Microsoft.AspNetCore.Http;

namespace BaseProject.Services.DTO.HelperDTO.Images
{
    public class UploadImageDto
    {
        public IFormFile image { get; set; }
        public int fileName { get; set; }
    }
}
