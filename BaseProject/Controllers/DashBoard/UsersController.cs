using BaseProject.Domain.Common.Helpers;
using BaseProject.Domain.Enums;
using BaseProject.Infrastructure.Extension;
using BaseProject.Services.DashBoard.Contract.UserInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Controllers.DashBoard
{
    [AuthorizeRolesAttribute(Roles.Admin, Roles.Clients)]

    public class UsersController : Controller
    {
        private readonly IUserServices _userServices;
        public UsersController(IHelper helper, IAppService appService, IUserServices userServices)
        {
            _userServices = userServices;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _userServices.GetUsers());
        }
        public async Task<IActionResult> ChangeState(string id)
        {
            bool IsActive = await _userServices.ChangeState(id);
            return Json(new { key = 1, data = IsActive });
        }
    }
}
