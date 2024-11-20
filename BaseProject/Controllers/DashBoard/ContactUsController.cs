using BaseProject.Domain.Enums;
using BaseProject.Infrastructure.Extension;
using BaseProject.Services.DashBoard.Contract.ContactUsInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace BaseProject.Controllers.DashBoard
{
    [AuthorizeRoles(Roles.Admin, Roles.ContactUs)]
    public class ContactUsController : Controller
    {
        private readonly IContactUsServices _contactUsServices;

        public ContactUsController(IContactUsServices contactUsServices)
        {
            _contactUsServices = contactUsServices;
        }

        // GET: ContactUs
        public async Task<IActionResult> Index()
        {
            return View(await _contactUsServices.GetContactUs());
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            bool IsDeleted = await _contactUsServices.DeleteContactUs(id);
            return Json(new { key = 1, data = IsDeleted });
        }
    }
}
