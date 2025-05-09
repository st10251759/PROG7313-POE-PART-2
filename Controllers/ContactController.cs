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

// Import the ASP.NET Core MVC framework namespace.
// This namespace provides the base classes and methods for building web applications using the Model-View-Controller (MVC) pattern.
using Microsoft.AspNetCore.Mvc;

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // Declare a public controller class named ContactController.
    // In ASP.NET Core MVC, a controller is responsible for handling HTTP requests, executing application logic, and returning responses to the client.
    public class ContactController : Controller
    {
        // Define an action method named Index.
        // The route is based on the controller and method names unless explicitly overridden.

        public IActionResult Index()
        {
            // This line returns a ViewResult, which tells the framework to render a Razor view.
            // Since no view name is specified, ASP.NET will look for a view file called "Index.cshtml"
            // inside the Views/Contact folder (Views/Contact/Index.cshtml).
            return View();
        }
    }
}
