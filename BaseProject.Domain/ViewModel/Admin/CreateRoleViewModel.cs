using System.ComponentModel.DataAnnotations;

namespace BaseProject.Domain.ViewModel.Admin
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
