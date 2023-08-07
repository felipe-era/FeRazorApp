var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();//.AddRazorRuntimeCompilation();//  

var app = builder.Build();

app.UseHttpsRedirection();//
app.UseStaticFiles();//apontaoroot~

app.UseRouting();//
app.MapRazorPages();//

app.Run();
