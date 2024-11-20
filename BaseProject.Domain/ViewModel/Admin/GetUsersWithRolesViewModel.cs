using BaseProject.Domain.Entities.UserTables;

namespace BaseProject.Domain.ViewModel.Admin
{
    public class GetUsersWithRolesViewModel
    {
        public List<ApplicationDbUser> users { get; set; }
        public List<string> roles { get; set; }
    }
}
