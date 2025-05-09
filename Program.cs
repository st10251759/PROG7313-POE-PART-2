/*
--------------------------------Student Information----------------------------------
STUDENT NO.: ST10251759
Name: Cameron Chetty
Course: BCAD Year 3
Module: Programming 3A - ENTERPRISE APPLICATION DEVELOPMENT 
Module Code: PROG7311
Assessment: Portfolio of Evidence (POE) Part 2
Github repo link: https://github.com/st10251759/PROG7313-POE-PART-2
--------------------------------Student Information----------------------------------

==============================Code Attribution==================================

Microsfot Identity
Author: Andy Malone MVP
Link: https://www.youtube.com/watch?v=zS79FDhAhBs
Date Accessed: 05 May 2025

MVC ASP.NET App connected to local SSMS Database
Author: Andy Malone MVP
Link: https://www.youtube.com/watch?app=desktop&v=ZX12X-ALwGA
Date Accessed: 05 May 2025

MVC APP
Author: Microsoft
Link: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-9.0&tabs=visual-studio
Date Accessed: 06 May 2025


==============================Code Attribution==================================

*/

using Microsoft.EntityFrameworkCore;                       // Provides EF Core functionalities for database access.
using ST10251759_PROG7313_POE_PART_2.Data;               // Imports the application's custom DbContext.
using Microsoft.AspNetCore.Identity;                     // Provides identity features such as user and role management.

namespace ST10251759_PROG7313_POE_PART_2
{
    // Entry point of the ASP.NET Core MVC application.
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a WebApplicationBuilder instance which is used to configure services and the app itself.
            var builder = WebApplication.CreateBuilder(args);

            // Register MVC controllers with views to the service container.
            // This enables model binding, validation, and view rendering (Razor Views).
            builder.Services.AddControllersWithViews();

            // Register the application’s DbContext with the built-in dependency injection (DI) container.
            // Configure it to use SQL Server as the database provider.
            // The connection string is retrieved from the appsettings.json file under the name "Prog7311DEV".
            builder.Services.AddDbContext<Prog7311DbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Prog7311DEV")));

            // Register identity services with support for:
            // - Default user management (login, registration, password hashing, etc.)
            // - Token generation for password reset and email confirmation
            // - Role-based authorization support
            // - Using EF Core for persisting identity data (users, roles) via Prog7311DbContext
            builder.Services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultTokenProviders()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<Prog7311DbContext>();

            // Build the WebApplication instance using the configured services.
            var app = builder.Build();

            // Configure middleware pipeline to handle HTTP requests.
            // If the application is *not* in the development environment:
            // - Enable global exception handling with a redirect to /Home/Error.
            // - Enable HTTP Strict Transport Security (HSTS) with a 30-day duration to enforce HTTPS.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts(); // Adds security header to prevent downgrade attacks and man-in-the-middle exploits.
            }

            // Redirect all HTTP traffic to HTTPS.
            app.UseHttpsRedirection();

            // Serve static files from the wwwroot folder (e.g., images, CSS, JavaScript).
            app.UseStaticFiles();

            // Enables routing capabilities to map incoming requests to route handlers (controllers or Razor Pages).
            app.UseRouting();

            // Enables authentication (login/logout flow).
            app.UseAuthentication();

            // Enables authorization (access control based on user roles/claims).
            app.UseAuthorization();

            // Enables routing for Razor Pages (used for Identity UI).
            app.MapRazorPages();

            // Defines the default route mapping for MVC controllers:
            // If no specific controller/action is provided in the URL, it will use HomeController and Index action.
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Run the application and start listening for incoming HTTP requests.
            app.Run();
        }
    }
}
