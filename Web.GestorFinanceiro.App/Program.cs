using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web.GestorFinanceiro.App.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddDbContext<WebGestorFinanceiroAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebGestorFinanceiroAppContext") ?? throw new InvalidOperationException("Connection string 'WebGestorFinanceiroAppContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
