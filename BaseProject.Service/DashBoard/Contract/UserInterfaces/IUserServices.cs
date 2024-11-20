using BaseProject.Domain.ViewModel.Users;

namespace BaseProject.Services.DashBoard.Contract.UserInterfaces
{
    public interface IUserServices
    {
        Task<List<UsersViewModel>> GetUsers();
        Task<bool> ChangeState(string UserId);
    }
}
