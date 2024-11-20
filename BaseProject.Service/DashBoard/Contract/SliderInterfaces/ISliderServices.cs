using BaseProject.Domain.ViewModel.Slider;

namespace BaseProject.Services.DashBoard.Contract.SliderInterfaces
{
    public interface ISliderServices
    {
        Task<List<SliderViewModel>> GetAllSliders();
        Task<bool> CreateSlider(CreateSliderViewModel slider);
        Task<EditSliderViewModel> GetSliderDetails(int? Id);
        Task<bool> EditSlider(EditSliderViewModel slider);
        Task<bool> ChangeState(int? id);
    }
}
