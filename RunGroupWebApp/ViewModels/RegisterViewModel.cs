using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name ="Email Address")]
        [Required(ErrorMessage ="Email Address Is Requried")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name="Confirm Password")]
        [Required(ErrorMessage ="confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password donot match")]
        public string? ConfirmPassword { get; set; }
    }
}
