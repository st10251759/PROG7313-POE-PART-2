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
 Date Accessed: 08 May 2025

==============================Code Attribution==================================

*/

//Note: This Controller was used before implementing part 2 requirements, and is been hiden in the nav bar.

// Import necessary namespaces for ASP.NET Core functionality
using Microsoft.AspNetCore.Authorization; // Enables role-based authorization
using Microsoft.AspNetCore.Identity;      // Provides APIs for managing roles and users
using Microsoft.AspNetCore.Mvc;           // Provides controller and action support in MVC pattern

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // This controller is only accessible to users assigned to the "Admin" role
    [Authorize(Roles = "Admin")]
    public class AppRolesController : Controller
    {
        // A private, read-only field to store the injected RoleManager dependency
        private readonly RoleManager<IdentityRole> _roleManager;

        // Constructor used for dependency injection to initialize the RoleManager
        public AppRolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        // Displays a list of all existing roles in the system
        public IActionResult Index()
        {
            // Fetches the collection of roles managed by the Identity system
            var roles = _roleManager.Roles;

            // Passes the list of roles to the view for display
            return View(roles);
        }

        // Serves the form that allows the Admin to create a new role
        [HttpGet]
        public IActionResult Create()
        {
            // Returns the empty form view for creating a new role
            return View();
        }

        // Handles form submission for creating a new role
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole model)
        {
            // Checks if a role with the given name already exists in the system
            // GetAwaiter().GetResult() forces the async task to complete synchronously (not recommended for production use)
            if (!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {
                // If the role doesn't exist, create a new IdentityRole using the name provided in the form
                _roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            }

            // After processing, redirect the user back to the Index page which lists all roles
            return RedirectToAction("Index");
        }
    }
}
