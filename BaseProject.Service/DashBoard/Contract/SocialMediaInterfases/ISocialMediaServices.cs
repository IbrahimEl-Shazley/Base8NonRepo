using BaseProject.Domain.ViewModel.SocialMedia;

namespace BaseProject.Services.DashBoard.Contract.SocialMediaInterfases
{
    public interface ISocialMediaServices
    {
        Task<List<SocialMediaViewModel>> GetSocialMedia();
        Task<bool> CreateSocialMedia(SocialMediaAddViewModel model);
        Task<SocialMediaEditViewModel> GetSocialMediaDetails(int? id);
        Task<bool> EditSocialMediaDetails(SocialMediaEditViewModel model);
        Task<bool> ChangeState(int? id);

    }
}
