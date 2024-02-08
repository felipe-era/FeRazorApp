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
        [Compare(nameof(Password), ErrorMessage = "As senhas estão diferentes")]
        public string ConfirmPassword { get; set; }


    }
}
