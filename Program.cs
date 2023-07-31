var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();//  

var app = builder.Build();

app.UseHttpsRedirection();//
app.UseStaticFiles();//apontaoroot

app.UseRouting();//
app.MapRazorPages();//

app.Run();
