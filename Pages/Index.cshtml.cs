using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace FeRazorApp.Pages;

public class IndexModel : PageModel
{

    public List<Category> Categories { get; set; } = new();

    public async Task OnGet()
    {
        await Task.Delay(5000);
        for (int i = 0; i < 100; i++)
        {
            Categories.Add(new Category(i, Title:"Categoria", Price:i*9.9M));//M = Decimal  
        }
    }
    public void OnPost()
    {

    }
}

public record Category(int Id, string Title, decimal Price);
