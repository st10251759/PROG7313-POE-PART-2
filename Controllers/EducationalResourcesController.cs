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

// Import the ASP.NET Core MVC namespace which provides the core MVC framework features
using Microsoft.AspNetCore.Mvc;

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // Defines a controller named EducationalResourcesController
    // Controllers are responsible for handling incoming HTTP requests, processing them,
    // and returning appropriate responses (e.g., a rendered view or data).
    public class EducationalResourcesController : Controller
    {
        // Action method that handles HTTP GET requests sent to /EducationalResources or /EducationalResources/Index
        public IActionResult Index()
        {
            // Returns the default view associated with this action.
            // In MVC, if no specific view name is provided, it returns the view that matches the action name.
            // Therefore, it will return Views/EducationalResources/Index.cshtml if it exists.
            return View();
        }
    }
}
