using BaseProject.Domain.ViewModel.ContactUs;

namespace BaseProject.Services.DashBoard.Contract.ContactUsInterfaces
{
    public interface IContactUsServices
    {
        Task<List<ContactUsViewModel>> GetContactUs();
        Task<bool> DeleteContactUs(int? id);
    }
}
