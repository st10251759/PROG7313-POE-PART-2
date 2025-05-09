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

// Necessary namespaces for ASP.NET Core functionality, identity management, and database operations
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ST10251759_PROG7313_POE_PART_2.Data;
using ST10251759_PROG7313_POE_PART_2.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // Only users assigned the "Employee" role can access this controller's actions
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        // Dependency-injected services for accessing the database, user accounts, and roles
        private readonly Prog7311DbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        // Constructor initializes the injected services
        public EmployeeController(Prog7311DbContext context, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // Fetch and display all users with the "Farmer" role
        public async Task<IActionResult> Farmers()
        {
            // Find the role with the name "Farmer"
            var farmerRoleId = await _roleManager.FindByNameAsync("Farmer");

            // If the role doesn't exist, return an empty view
            if (farmerRoleId == null)
                return View(new List<ApplicationUser>());

            // Query all users who have been assigned the "Farmer" role
            var farmersQuery = from user in _context.ApplicationUsers
                               join userRole in _context.UserRoles on user.Id equals userRole.UserId
                               where userRole.RoleId == farmerRoleId.Id
                               select user;

            // Execute the query and return the result to the view
            var farmers = await farmersQuery.ToListAsync();
            return View(farmers);
        }

        // Display the form to create a new farmer
        public IActionResult CreateFarmer()
        {
            return View();
        }

        // Handle POST request to create a new farmer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFarmer(RegisterFarmerViewModel model)
        {
            // Validate model state
            if (ModelState.IsValid)
            {
                // Create a new ApplicationUser based on the form input
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    PhoneNumber = model.PhoneNumber,
                    Location = model.Location
                };

                // Create the user with the provided password
                var result = await _userManager.CreateAsync(user, model.Password);

                // If user creation is successful, assign the "Farmer" role and redirect
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Farmer");
                    return RedirectToAction(nameof(Farmers));
                }

                // Add any validation errors to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // Return the view with validation messages
            return View(model);
        }

        // Display a confirmation page for deleting a farmer
        public async Task<IActionResult> DeleteFarmer(string id)
        {
            //Validation if id is null - no user - return 404 Error Page
            if (id == null)
            {
                return NotFound();
            }
            //Find the user in the database list of users
            var user = await _context.ApplicationUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            // Validation to Ensure the user is in the "Farmer" role
            var isInRole = await _userManager.IsInRoleAsync(user, "Farmer");
            if (!isInRole)
            {
                return NotFound();
            }

            return View(user);
        }

        // Handle POST request to delete the farmer permanently
        [HttpPost, ActionName("DeleteFarmer")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteFarmerConfirmed(string id)
        {
            var user = await _context.ApplicationUsers.FindAsync(id);
            //Validation if the user is not found return 404 Error Page
            if (user == null)
            {
                return NotFound();
            }

            // Confirm the user has the "Farmer" role before deletion
            var isInRole = await _userManager.IsInRoleAsync(user, "Farmer");
            if (!isInRole)
            {
                return NotFound();
            }

            // Remove all products created by the farmer before deleting the farmer account
            var products = await _context.Products.Where(p => p.UserId == id).ToListAsync();
            _context.Products.RemoveRange(products);

            // Delete the farmer's user account
            await _userManager.DeleteAsync(user);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Farmers));
        }

        // Display list of products with filtering options
        public async Task<IActionResult> Products(DateTime? fromDate, DateTime? toDate, string category, string searchString)
        {
            // Start building the query with included User reference
            var productsQuery = _context.Products.Include(p => p.User).AsQueryable();

            // Apply date range filter if provided
            if (fromDate.HasValue)
            {
                productsQuery = productsQuery.Where(p => p.ProductionDate >= fromDate.Value);
            }

            if (toDate.HasValue)
            {
                productsQuery = productsQuery.Where(p => p.ProductionDate <= toDate.Value);
            }

            // Apply category filter
            if (!string.IsNullOrEmpty(category))
            {
                productsQuery = productsQuery.Where(p => p.Category == category);
            }

            // Apply full-text search on product and user details
            if (!string.IsNullOrEmpty(searchString))
            {
                productsQuery = productsQuery.Where(p =>
                    p.Name.Contains(searchString) ||
                    p.Description.Contains(searchString) ||
                    p.User.Firstname.Contains(searchString) ||
                    p.User.Lastname.Contains(searchString) ||
                    p.User.Email.Contains(searchString));
            }

            // Execute the query and return the result
            var products = await productsQuery.ToListAsync();

            // Prepare dropdown data and filters for reuse in the view
            ViewBag.Categories = await _context.Products.Select(p => p.Category).Distinct().ToListAsync();
            ViewBag.FromDate = fromDate;
            ViewBag.ToDate = toDate;
            ViewBag.Category = category;
            ViewBag.SearchString = searchString;

            return View(products);
        }

        // Display detailed information for a specific product
        public async Task<IActionResult> ProductDetails(int? id)
        {
            // If no ID is provided, return a 404 page
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve the product with related user information
            var product = await _context.Products
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProductId == id);

            //Validation for no products
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
