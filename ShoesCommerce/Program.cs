using Microsoft.EntityFrameworkCore;
using ShoesCommerce.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ShoesCommerceDbContext>(options=>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShoesDb"));
});

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute("ChangeLanguage", "dildegistir/{lang:length(5)}", new { controller = "Common", action = "ChangeLanguage" });

app.MapControllerRoute(
        name:"ProductDetail",
        pattern: "ayakkabi/{id:required}",
        defaults: new { controller = "Product", action = "Detail" });

app.MapControllerRoute(
        name: "CategoryDetail",
        pattern: "kategori/{id?}",
        defaults: new { controller = "Category", action = "List" });

app.Run();
