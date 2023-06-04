using Microsoft.EntityFrameworkCore;
using RentaCar.BLL.DesignPatterns.GenericRepository.ConcRep;
using RentaCar.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependency Enjection
builder.Services.AddDbContext<MyContext>();
builder.Services.AddScoped<CarRepository>();
builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<OrderRepository>();

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
