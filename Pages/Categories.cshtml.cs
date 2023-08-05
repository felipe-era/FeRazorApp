using Microsoft.AspNetCore.Mvc.RazorPages;
namespace FeRazorApp.Pages;

public class CategoriesModel : PageModel
{

    public List<Category> CategoryList { get; set; } = new();

    public void OnGet(int skip, int take)
    {
        var lstAuxCategory = new List<Category>();
        //await Task.Delay(5000);
        for (int i = 0; i < 100; i++)
        {
            CategoryList.Add(new Category(i, Title: "Categoria", Price: i * 9.9M));//M = Decimal  
            lstAuxCategory.Add(new Category(i, Title: "Categoria", Price: i * 9.9M));//M = Decimal  

        }
        CategoryList = lstAuxCategory
            .Skip(skip)
            .Take(take)
            .ToList();

    }
    public void OnPost()
    {

    }
}

public record Category(int Id, string Title, decimal Price);
