using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using myPet;
using myPet2;
using System.Configuration;
using System.Data.Entity;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddDbContext<myPetContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");


app.Run();
