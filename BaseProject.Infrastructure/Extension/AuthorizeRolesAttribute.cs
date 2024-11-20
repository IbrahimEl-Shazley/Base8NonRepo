namespace BaseProject.Infrastructure.Extension
{
    public class AuthorizeRolesAttribute : Microsoft.AspNetCore.Authorization.AuthorizeAttribute
    {
        public AuthorizeRolesAttribute(params BaseProject.Domain.Enums.Roles[] roles) : base()
        {
            Roles = string.Join(",", roles);
        }
    }
}
