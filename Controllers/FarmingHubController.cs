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

// Import the Microsoft.AspNetCore.Mvc namespace.
// This namespace provides the foundational components for building ASP.NET Core MVC applications,
// including the base Controller class, action result types (e.g., IActionResult), and features for handling HTTP requests and responses.
using Microsoft.AspNetCore.Mvc;

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // Declare a public controller class named 'FarmingHubController'.
    public class FarmingHubController : Controller
    {
        // Define an action method named 'Index'.
        public IActionResult Index()
        {
            // This line returns a View to the client (i.e., the browser or front-end application).
            // By default, it will attempt to load a Razor view named 'Index.cshtml'.
            // The view file should be located in the /Views/FarmingHub folder (which corresponds to the controller name),
            // resulting in the full expected path: /Views/FarmingHub/Index.cshtml.

            // This follows the MVC convention of matching controller names to folders and action names to views.

            return View();
        }
    }
}
