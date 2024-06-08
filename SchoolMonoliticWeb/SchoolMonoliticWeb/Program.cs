using Microsoft.EntityFrameworkCore;
using SchoolMonoliticWeb.BL.Interfaces;
using SchoolMonoliticWeb.BL.Services;
using SchoolMonoliticWeb.Data.Context;
using SchoolMonoliticWeb.Data.Daos;
using SchoolMonoliticWeb.Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SchoolContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolContext")));


// Agregar las dependencias del objeto de datos //
builder.Services.AddScoped<IDepartmentDb, DepartmentDb>();


// Agregar las dependencias del BL //
builder.Services.AddTransient<IDepartmentService, DepartmentService>();



builder.Services.AddControllersWithViews();

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
