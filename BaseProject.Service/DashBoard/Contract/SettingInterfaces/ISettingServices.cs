using BaseProject.Domain.ViewModel.Settings;

namespace BaseProject.Services.DashBoard.Contract.SettingInterfaces
{
    public interface ISettingServices
    {
        Task<SettingEditViewModel> GetSetting(int? id);
        Task<bool> EditSetting(SettingEditViewModel settingEditViewModel);
        bool SettingExists(int id);
    }
}
