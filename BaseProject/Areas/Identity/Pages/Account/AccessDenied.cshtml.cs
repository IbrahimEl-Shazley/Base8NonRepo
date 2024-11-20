using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BaseProject.Areas.Identity.Pages.Account
{
    public class AccessDeniedModel : PageModel
    {
        public void OnGet()
        {
            RedirectToPage("Login");
        }
    }
}

