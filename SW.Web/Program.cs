using Microsoft.EntityFrameworkCore;
using SW.DataAcessLayer;
using SW.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StarWarsDBContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("SW"));
});
// injection des dependances 
//quand j'ai besoin d'un metier 
//sim j'appel le division citoyen tu me fait une instance 
builder.Services.AddScoped<DivisionCitoyen>();
builder.Services.AddScoped<CitoyenRepository>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
