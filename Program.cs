using FeRazorApp.Data;
using FeRazorApp.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();//.AddRazorRuntimeCompilation();//  

builder.Services.AddDbContext<ApplicationDbContext>(option=>option.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
builder.Services.AddDbContext<AuthDbContext>(option => option.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AuthDbContext>();


var app = builder.Build();

app.UseHttpsRedirection();//
app.UseStaticFiles();//apontaoroot~

app.UseRouting();//
app.MapRazorPages();//

app.Run();

app.UseAuthentication();
