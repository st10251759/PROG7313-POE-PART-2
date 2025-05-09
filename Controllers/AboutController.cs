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

MVC APP
Author: Microsoft
Link: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-9.0&tabs=visual-studio
Date Accessed: 07 May 2025

==============================Code Attribution==================================

*/

using Microsoft.AspNetCore.Mvc; // Provides classes and interfaces for building web APIs and MVC apps (e.g., Controller, IActionResult, etc.)

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // This controller handles requests related to the "About" section of the application.
    // It inherits from the base Controller class provided by ASP.NET Core MVC, 
    // which gives it access to methods and properties like View(), RedirectToAction(), ModelState, etc.
    public class AboutController : Controller
    {
        // This action method responds to HTTP GET requests to /About or /About/Index.
        // When invoked, it returns a view corresponding to the "Index" page within the "Views/About" folder.
        // Since there is no logic here, it's simply responsible for rendering the static About page.
        public IActionResult Index()
        {
            return View(); // Returns the default view associated with this action (Views/About/Index.cshtml)
        }
    }
}
