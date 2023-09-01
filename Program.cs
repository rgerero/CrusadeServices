using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CrusadeServices.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using CrusadeServices.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CrusadeServicesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CrusadeServicesContext") ?? throw new InvalidOperationException("Connection string 'CrusadeServicesContext' not found.")));

builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/Access/Login";
        option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
    });

var app = builder.Build();

using(var scope=app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

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
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Access}/{action=Login}/{id?}");

app.Run();
