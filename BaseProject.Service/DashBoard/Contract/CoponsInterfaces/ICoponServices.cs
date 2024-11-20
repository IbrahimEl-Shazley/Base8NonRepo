using BaseProject.Domain.Entities.Copon;
using BaseProject.Domain.ViewModel.Copon;

namespace BaseProject.Services.DashBoard.Contract.CoponsInterfaces
{
    public interface ICoponServices
    {
        Task<List<CoponViewModel>> GetCopons();
        Task<bool> CreateCopon(CoponCreateViewModel createCoponViewModel);
        Task<Copon> GetCopon(int? CoponId);
        Task<bool> EditCopon(int id, CoponCreateViewModel createCoponViewModel);
        bool IsExist(string CoponCode);
        bool IsExist(int? CoponId);
        Task<bool> ChangeState(int? id);
        Task<bool> DeleteCopons(int? id);

    }
}
