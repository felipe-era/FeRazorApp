using FeRazorApp.Model;
using FeRazorApp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FeRazorApp.Pages.Login
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login2 Model { get; set; } //bug no vs, ele confunde o nome e realizava a chamada incorretamente
        private readonly SignInManager<IdentityUser> signInManager;

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, false, false);
                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }
                ModelState.AddModelError("", "Email ou senha incorretos.");
            }
            return Page();
        }
    }
}
