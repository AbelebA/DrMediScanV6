using DrMediScanV6.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;  // For CreateScope()
using DrMediScanV5.Services;
using DrMediScanV6.Services;
using Microsoft.AspNetCore.Authentication.Google;
using DinkToPdf;
using DinkToPdf.Contracts;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Setup Identity with Roles
builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>() // Adds Role services
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthentication()
    .AddGoogle(googleoptions =>
    {
        googleoptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];
        googleoptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
        googleoptions.CallbackPath = "/signin-google";
    });

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
});

//builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);
builder.Services.AddTransient<IExtendedEmailSender, EmailSender>();
builder.Services.AddSingleton(typeof(SynchronizedConverter), new SynchronizedConverter(new PdfTools()));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Seed Roles
using var scope = app.Services.CreateScope();
var serviceProvider = scope.ServiceProvider;
var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

if (!roleManager.RoleExistsAsync("Patient").Result)
{
    roleManager.CreateAsync(new IdentityRole("Patient")).Wait();
}

if (!roleManager.RoleExistsAsync("Administrator").Result)
{
    roleManager.CreateAsync(new IdentityRole("Administrator")).Wait();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); // Add this to use the authentication middleware
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
