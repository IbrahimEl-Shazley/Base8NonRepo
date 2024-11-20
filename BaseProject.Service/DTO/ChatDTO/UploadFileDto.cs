using Microsoft.AspNetCore.Http;

namespace BaseProject.Services.DTO.ChatDTO
{
    public class UploadFileDto
    {
        public IFormFile File { get; set; }
    }
}
