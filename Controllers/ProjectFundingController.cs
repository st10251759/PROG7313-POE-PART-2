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

// Import the ASP.NET Core MVC framework namespace, which provides classes and interfaces
// for building web applications using the Model-View-Controller (MVC) design pattern.
using Microsoft.AspNetCore.Mvc;

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // Define a controller class named ProjectFundingController.
    // It inherits from the base Controller class provided by ASP.NET Core MVC.
    // Controllers handle user requests, interact with the model, and return views or results.
    public class ProjectFundingController : Controller
    {
        // Define an action method named Index.
        // Action methods are responsible for responding to incoming HTTP requests.
      
        public IActionResult Index()
        {
            // Return the default view associated with this action method.
            // By convention, this will load a Razor view named "Index.cshtml"
            // located in the Views/ProjectFunding folder (matching the controller name).

            return View();
        }
    }
}
