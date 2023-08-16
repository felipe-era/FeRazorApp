using FeRazorApp.Data;
using FeRazorApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeRazorApp.Pages.Categories;

[BindProperties]
public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _db;
    public Category Category { get; set; }

    public DeleteModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        Category = _db.Category.Find(id);
        //Category = _db.Category.FirstOrDefault(u=>u.Id==id);
        //Category = _db.Category.SingleOrDefault(u=>u.Id==id);
        //Category = _db.Category.Where(u=>u.Id==id).FirstOrDefault();

    }

    public async Task<IActionResult> OnPost(Category category)
    {
        if (Category.Name == Category.DisplayOrder.ToString())
        {
            ModelState.AddModelError(Category.Name, "DisplayOrder e Nomes não podem ser iguais");
        }
        if (ModelState.IsValid)
        {
            _db.Category.Update(category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
        return Page();
    }
}
