using BaseProject.Domain.Enums;
using BaseProject.Domain.Model;
using BaseProject.Persistence;
using BaseProject.Services.DashBoard.Contract.HomeInterfaces;

namespace BaseProject.Services.DashBoard.Implementation.HomeImplementation
{
    public class HomeServices : IHomeServices
    {
        private readonly ApplicationDbContext _context;

        public HomeServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public DashBoardHomeModel HomeIndex()
        {
            var data = (from st in _context.Settings
                        let UserCount = _context.Users.Where(x => x.AccountType == UserType.Client).Count()
                        select new DashBoardHomeModel
                        {
                            UserCount = UserCount
                        }).FirstOrDefault();

            return data;
        }
    }
}
