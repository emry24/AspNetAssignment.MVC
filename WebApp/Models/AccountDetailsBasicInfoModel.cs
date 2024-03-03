using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApp.Models
{
    public class AccountDetailsBasicInfoModel
    {
        [DataType(DataType.ImageUrl)]
        public string? ProfileImage { get; set; }


        [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = null!;

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address", Prompt = "Enter your email address", Order = 2)]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[^\s@]+@[^\s@]+\.[^\s@]{2,}$", ErrorMessage = "Your email address is invalid")]
        public string Email { get; set; } = null!;

        [Display(Name = "Phone", Prompt = "Enter your phone", Order = 3)]
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; } = null!;

        [Display(Name = "Bio", Prompt = "Add a short bio...", Order = 4)]
        [DataType(DataType.MultilineText)]
        public string? Biography { get; set; }
    }
}
