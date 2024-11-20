using Microsoft.AspNetCore.Builder;

namespace BaseProject.Services.Middlewares.UserConfigs
{
    public static class UserConfigMiddlewareExtensions
    {
        public static IApplicationBuilder UseUserConfigMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserConfigMiddleware>();
        }
    }
}
