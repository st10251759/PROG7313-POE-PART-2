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

 Microsfot Identity
 Author: Andy Malone MVP
 Link: https://www.youtube.com/watch?v=zS79FDhAhBs
 Date Accessed: 08 May 2025

 Database Work
 Author: Microsoft
 Link: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-8.0&tabs=visual-studio
 Date Accessed: 08 May 2025

 LINQ Resource
 Author: Grant Riordan
 Link: https://www.freecodecamp.org/news/how-to-use-linq/
 Date Accessed: 08 May 2025

==============================Code Attribution==================================

*/

//Note this is a deleted commenting of the structure of a controller and can be applied to the other controllers

// Import the ASP.NET Core MVC namespace.
using Microsoft.AspNetCore.Mvc;

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // Define a public controller class named 'MarketPlaceController'.

    // The controller inherits from the base 'Controller' class provided by ASP.NET Core MVC.
    public class MarketPlaceController : Controller
    {
        // Define an action method named 'Index'.
        // Action methods are endpoints that handle incoming HTTP requests.
        // The 'Index' method is typically the default action for a controller and 
        // is usually accessed via the root path of the controller (e.g., /MarketPlace).

        // The return type 'IActionResult' is an interface used to represent the result of an action method.
        // It allows returning different types of HTTP responses, such as:
        // - Views (HTML pages)
        // - JSON data
        // - Redirects
        // - Error status codes

        public IActionResult Index()
        {
            // Call the 'View()' method to return a ViewResult object.
            // This renders a Razor view (typically named 'Index.cshtml') to the user.
            // By convention, this view is expected to be located at:
            // /Views/MarketPlace/Index.cshtml — where 'MarketPlace' matches the controller name.

            // If the view file does not exist at the expected path, a runtime error will occur
            // unless a different path is specified explicitly in the View() call.

            return View();
        }
    }
}
