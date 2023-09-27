using System.ComponentModel.DataAnnotations;

namespace FeRazorApp.Model
{
    public class Login2
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public string RememberMe{ get; set; }
    }
}
