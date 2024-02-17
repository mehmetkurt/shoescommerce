using ShoesCommerce.Web.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddShoesCommerceMvc();
builder.Services.AddShoesCommerceDataContext(builder.Configuration, "ShoesDb");

builder.Services.RegisterCommonDependencies();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute("ChangeLanguage", "dildegistir/{lang:length(5)}", new { controller = "Common", action = "ChangeLanguage" });


app.Run();
