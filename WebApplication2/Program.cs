using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using WebApplication2.Models;

var builder = WebApplication.CreateBuilder(args);

//получаем строку подключения из appsettings.json
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

//настраиваме сервис
builder.Services.AddDbContext<AppIdentityDbContext>
    (options => options.UseSqlServer(connection));

builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<AppIdentityDbContext>()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IValidator<Message>, MessageValidator>();

builder.Services.ConfigureApplicationCookie
    (options => options.LoginPath = "/Account/Login");


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
