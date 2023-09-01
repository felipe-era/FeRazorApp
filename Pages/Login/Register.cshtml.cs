using FeRazorApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeRazorApp.Pages.Login;

public class RegisterModel : PageModel
{
    public Register Model { get; set; }
    public void OnGet()
    {
    }
}
