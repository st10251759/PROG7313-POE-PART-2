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

// Controllers/AdminController.cs

// Import necessary namespaces
using Microsoft.AspNetCore.Authorization; // Enables role-based and policy-based authorization
using Microsoft.AspNetCore.Identity; // Provides identity management (users, roles, passwords, etc.)
using Microsoft.AspNetCore.Mvc; // Enables MVC controller and routing functionality
using Microsoft.EntityFrameworkCore; // Enables async LINQ operations on DbContext
using ST10251759_PROG7313_POE_PART_2.Data; // Reference to the application's database context
using ST10251759_PROG7313_POE_PART_2.Models; // Reference to model and view model classes
using System.Collections.Generic; // Provides collection types like List<>
using System.ComponentModel.DataAnnotations; // Provides validation attributes
using System.Linq; // Provides LINQ query capabilities
using System.Threading.Tasks; // Enables asynchronous programming with async/await

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // Restricts access to this controller to users in the "Admin" role only
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // Declare private read-only fields for dependency injection
        private readonly Prog7311DbContext _context; // The database context for interacting with the application's data
        private readonly UserManager<IdentityUser> _userManager; // Manages users (create, delete, assign roles, etc.)
        private readonly RoleManager<IdentityRole> _roleManager; // Manages roles (create, find, delete, etc.)

        // Constructor: injects the DbContext, UserManager, and RoleManager services
        public AdminController(Prog7311DbContext context, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Admin/Employees
        // Displays a list of all users in the "Employee" role
        public async Task<IActionResult> Employees()
        {
            // Attempt to retrieve the "Employee" role by name
            var employeeRoleId = await _roleManager.FindByNameAsync("Employee");

            // If the role is not found, return an empty list to the view
            if (employeeRoleId == null)
                return View(new List<ApplicationUser>());

            // Use LINQ to query all users assigned to the "Employee" role
            var employeesQuery = from user in _context.ApplicationUsers
                                 join userRole in _context.UserRoles on user.Id equals userRole.UserId
                                 where userRole.RoleId == employeeRoleId.Id
                                 select user;

            // Execute the query asynchronously and return the result to the view
            var employees = await employeesQuery.ToListAsync();
            return View(employees);
        }

        // GET: Admin/CreateEmployee
        // Displays the form to create a new employee user
        public IActionResult CreateEmployee()
        {
            return View();
        }

        // POST: Admin/CreateEmployee
        // Handles the form submission for creating a new employee
        [HttpPost]
        [ValidateAntiForgeryToken] // Protects against CSRF attacks
        public async Task<IActionResult> CreateEmployee(RegisterEmployeeViewModel model)
        {
            // Check if the form input is valid based on validation attributes
            if (ModelState.IsValid)
            {
                // Create a new ApplicationUser instance with the input values
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname
                };

                // Attempt to create the user with the specified password
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // If creation is successful, add the user to the "Employee" role
                    await _userManager.AddToRoleAsync(user, "Employee");

                    // Redirect to the employee list page
                    return RedirectToAction(nameof(Employees));
                }

                // If errors occur, add them to the ModelState for display in the view
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we reach this point, something failed; redisplay the form with validation messages
            return View(model);
        }

        // GET: Admin/DeleteEmployee/5
        // Displays a confirmation page to delete the specified employee
        public async Task<IActionResult> DeleteEmployee(string id)
        {
            // Validate if the user ID was provided
            if (id == null)
            {
                return NotFound();
            }

            // Attempt to retrieve the user from the database
            var user = await _context.ApplicationUsers.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            // Ensure the user is actually an employee before allowing deletion
            var isInRole = await _userManager.IsInRoleAsync(user, "Employee");
            if (!isInRole)
            {
                return NotFound();
            }

            // Display the confirmation view
            return View(user);
        }

        // POST: Admin/DeleteEmployee/5
        // Confirms and executes deletion of the specified employee
        [HttpPost, ActionName("DeleteEmployee")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteEmployeeConfirmed(string id)
        {
            // Find the user to delete
            var user = await _context.ApplicationUsers.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            // Confirm the user is an employee
            var isInRole = await _userManager.IsInRoleAsync(user, "Employee");
            if (!isInRole)
            {
                return NotFound();
            }

            // Delete the user from the Identity system
            await _userManager.DeleteAsync(user);

            // Save changes to the database (if needed)
            await _context.SaveChangesAsync();

            // Redirect back to the employee list
            return RedirectToAction(nameof(Employees));
        }
    }
}

