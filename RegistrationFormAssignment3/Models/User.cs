using RegistrationFormAssignment3.validation;
using System.ComponentModel.DataAnnotations;

namespace RegistrationFormAssignment3.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name is not empty.")]
        public string Name { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Username should be atleast 3 characters.")]
        public string Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter valid email address.")]
        public string Email { get; set; }

        [Required]
        [RegularExpression("(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$@!%&*?]).*"
            , ErrorMessage = "Password should consist atlease 1 uppercase character, 1 lowercase character, 1 special character and a number.")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password should be atleast 8 characters.")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression("^[6789]\\d{9}$", ErrorMessage = "Please Enter Correct Mobile Number.")]
        public string Contact { get; set; }

        [Required]
        public string Gender { get; set; }

        [Display(Name = "Accept Terms")]
        [CheckBoxValidation(ErrorMessage = "Please Accept Terms")]
        public bool IsTerms { get; set; }
    }
}
