using BaseProject.Domain.Entities.UserTables;
using BaseProject.Domain.ViewModel.Admin;

namespace BaseProject.Services.DashBoard.Contract.AdminInterfaces
{
    public interface IAdminServices
    {
        Task<bool> EditUsersInRoles(UserRolesViewModel obj);
        Task<GetUsersWithRolesViewModel> GetUsersWithRoles();
        Task<List<ApplicationDbUser>> ListUsers();
        Task<List<RolesViewModel>> ListRoles();
        Task<UserWithRolesViewModel> EditUserRoles(UserIdViewModel userId);
    }
}
