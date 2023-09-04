using FeRazorApp.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeRazorApp.Pages.Login;

public class RegisterModel : PageModel
{
    private readonly UserManager<IdentityUser> userManager;
    private readonly SignInManager<IdentityUser> signInManager;

    [BindProperty]
    public Register Model { get; set; }

    public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    {
        this.signInManager = signInManager;
        this.userManager = userManager;
    }
    public void OnGet()
    {
    }

    public async Task<IActionResult>OnPostAsync()
    { 
        if (ModelState.IsValid)
        {
            var user = new IdentityUser()
            {
                UserName = Model.Email,
                Email = Model.Email
            };

            var result = userManager.CreateAsync(user, Model.Password);
            if (result.IsCompletedSuccessfully)//verificar outras opções do result. (succeded?)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToPage("Index");
            }

            foreach (var error in result.Result.Errors)
            {
                ModelState.AddModelError("", error.Description);

            }

        }

        return Page();

    }
}
