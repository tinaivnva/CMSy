using CMSy.DataFolder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

<<<<<<< HEAD
builder.Services.AddDbContext<MVCOrderDbContext>(c => 
    c.UseMySQL("Server=localhost;Database=tina;Uid=codeUser;Pwd=1234;"));
=======
builder.Services.AddDbContext<MVCDemoDbContext>(c => 
    c.UseMySQL("Server=127.0.0.1;Database=tina;Uid=root;Pwd=TinaITsveti;"));
>>>>>>> 3995bb7e4ee54bfcab4e24ab2f141e355f065394

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
