using FeRazorApp.Data;
using FeRazorApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeRazorApp.Pages.Categories;

[BindProperties]
public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _db;
    public Category Category { get; set; }

    public CreateModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPost(Category category)
    {
        try
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                //ModelState.AddModelError(string.Empty, "DisplayOrder e Nomes não podem ser iguais");
                ModelState.AddModelError(Category.Name, "DisplayOrder e Nomes não podem ser iguais");
            }
            if (ModelState.IsValid)
            {
                await _db.Category.AddAsync(category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Categoria criada com sucesso.";

                return RedirectToPage("Index");
            }
        }
        catch (Exception ex)
        {
            TempData["error"] = ex.ToString();
        }
        return Page();
    }
}
