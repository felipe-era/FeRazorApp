using FeRazorApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();//.AddRazorRuntimeCompilation();//  

builder.Services.AddDbContext<ApplicationDbContext>(option=>option.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));


var app = builder.Build();

app.UseHttpsRedirection();//
app.UseStaticFiles();//apontaoroot~

app.UseRouting();//
app.MapRazorPages();//

app.Run();
