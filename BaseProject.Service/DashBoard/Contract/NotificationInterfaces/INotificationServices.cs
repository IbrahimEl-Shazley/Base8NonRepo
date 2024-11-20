using BaseProject.Domain.ViewModel.Notification;

namespace BaseProject.Services.DashBoard.Contract.NotificationInterfaces
{
    public interface INotificationServices
    {
        Task<List<HistoryNotificationViewModel>> GetHistoryNotify();
        Task<List<UsersViewModel>> GetUsers();
        Task<bool> Send(string msg, string users);
    }
}
