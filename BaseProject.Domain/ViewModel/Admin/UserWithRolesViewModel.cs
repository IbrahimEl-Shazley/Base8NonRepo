using BaseProject.Domain.Entities.UserTables;
using Microsoft.AspNetCore.Identity;

namespace BaseProject.Domain.ViewModel.Admin
{
    public class UserWithRolesViewModel
    {
        public List<IdentityRole> userRoles { get; set; }
        public ApplicationDbUser user { get; set; }

    }
}
