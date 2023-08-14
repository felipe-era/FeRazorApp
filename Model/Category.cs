using System.ComponentModel.DataAnnotations;

namespace FeRazorApp.Model;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Nome")]
    [Required]
    public string Name { get; set; }
    [Display(Name="Ordem Exibição")]
    [Range(1,100, ErrorMessage ="Valor deve estar entre 1 a 100!")]
    public int DisplayOrder { get; set; }
}
