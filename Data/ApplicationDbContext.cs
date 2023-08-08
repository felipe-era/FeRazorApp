using FeRazorApp.Model;
using Microsoft.EntityFrameworkCore;

namespace FeRazorApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Category { get; set; }


}
