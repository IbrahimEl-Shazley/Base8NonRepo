﻿using Microsoft.AspNetCore.Http;

namespace BaseProject.Services.DTO.SocialMediaDTO
{
    public class SocialMediaEditDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public IFormFile img { get; set; }
        public string url { get; set; }
    }
}
