var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
var app = builder.Build();


app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(e =>
{
  e.MapControllerRoute("default", "{controller}/{action}");
});
app.Run();