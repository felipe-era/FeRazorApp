using FeRazorApp.Model;
using FeRazorApp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeRazorApp.Pages.Login
{

    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login2 Model { get; set; } //bug no vs, ele confunde o nome e realizava a chamada incorretamente
        public void OnGet()
        {
        }
    }
}
