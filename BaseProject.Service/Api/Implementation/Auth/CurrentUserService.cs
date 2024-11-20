using BaseProject.Services.Api.Contract.Auth;
using Microsoft.AspNetCore.Http;

namespace BaseProject.Services.Api.Implementation.Auth
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string UserId => _httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
    }
}
