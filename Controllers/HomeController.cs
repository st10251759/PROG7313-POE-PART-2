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

Author: w3schools
Link: https://www.w3schools.com/html/
Date Accessed: 08 May 2025

Author: w3schools
Link: https://www.w3schools.com/css/
Date Accessed: 08 May 2025

==============================Code Attribution==================================
*/

// The following 'using' directives bring external namespaces into the file,
// allowing access to core MVC functionality and application-specific models.
using Microsoft.AspNetCore.Mvc; // Provides classes and interfaces to build web APIs and MVC apps (e.g., Controller, IActionResult)
using ST10251759_PROG7313_POE_PART_2.Models; // Imports the namespace where your ErrorViewModel and possibly other models are defined
using System.Diagnostics; // Provides access to diagnostic information such as the current request's activity ID

// Declare the namespace this controller belongs to. This helps in organizing your code.
// Typically, the namespace matches the project structure and directory path.
namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // HomeController class which inherits from ASP.NET Core's Controller base class.
    // This controller is generally used to serve the main (home) pages of the web application.
    public class HomeController : Controller
    {
        // Declare a private, read-only field of type ILogger<HomeController>.
        // This is used to log information, warnings, errors, and diagnostics related to this controller.
        private readonly ILogger<HomeController> _logger;

        // Constructor: Called automatically when an instance of HomeController is created.
        // The ILogger is injected via dependency injection, a design pattern that promotes loose coupling.
        public HomeController(ILogger<HomeController> logger)
        {
            // Assign the injected logger to the private field so it can be used throughout the class.
            _logger = logger;
        }

        // This action handles GET requests to the root/home route (e.g., / or /Home/Index).
        // It returns the default Razor view associated with this action — typically Views/Home/Index.cshtml.
        public IActionResult Index()
        {
            // Return the Index view without any model data.
            return View();
        }

        // This action handles unexpected errors or exceptions that occur during runtime.
        // It's often invoked when the app is configured to use a global error handler.
        // The ResponseCache attribute disables caching of the error page so that each error gets a fresh response.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Create a new instance of ErrorViewModel and pass it to the Error view.
            // 'RequestId' helps identify and trace the request where the error occurred.
            // Activity.Current?.Id returns the current activity ID if available; otherwise, it falls back to HttpContext.TraceIdentifier.
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
