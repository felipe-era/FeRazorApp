using System.ComponentModel.DataAnnotations;

namespace FeRazorApp.Model
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The Password não batem")]
        public string ConfirmPassword { get; set; }


    }
}
