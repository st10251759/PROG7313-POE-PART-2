// Controllers/EmployeeController.cs
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
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        private readonly Prog7311DbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public EmployeeController(Prog7311DbContext context, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Employee/Farmers
        public async Task<IActionResult> Farmers()
        {
            var farmerRoleId = await _roleManager.FindByNameAsync("Farmer");
            if (farmerRoleId == null)
                return View(new List<ApplicationUser>());

            var farmersQuery = from user in _context.ApplicationUsers
                               join userRole in _context.UserRoles on user.Id equals userRole.UserId
                               where userRole.RoleId == farmerRoleId.Id
                               select user;

            var farmers = await farmersQuery.ToListAsync();
            return View(farmers);
        }

        // GET: Employee/CreateFarmer
        public IActionResult CreateFarmer()
        {
            return View();
        }

        // POST: Employee/CreateFarmer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFarmer(RegisterFarmerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    PhoneNumber = model.PhoneNumber,
                    Location = model.Location
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Farmer");
                    return RedirectToAction(nameof(Farmers));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        // GET: Employee/DeleteFarmer/5
        public async Task<IActionResult> DeleteFarmer(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.ApplicationUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            // Check if the user is actually a farmer
            var isInRole = await _userManager.IsInRoleAsync(user, "Farmer");
            if (!isInRole)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Employee/DeleteFarmer/5
        [HttpPost, ActionName("DeleteFarmer")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteFarmerConfirmed(string id)
        {
            var user = await _context.ApplicationUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            // Check if the user is actually a farmer
            var isInRole = await _userManager.IsInRoleAsync(user, "Farmer");
            if (!isInRole)
            {
                return NotFound();
            }

            // Delete all products from this farmer
            var products = await _context.Products.Where(p => p.UserId == id).ToListAsync();
            _context.Products.RemoveRange(products);

            // Delete the user
            await _userManager.DeleteAsync(user);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Farmers));
        }

        // GET: Employee/Products
        public async Task<IActionResult> Products(DateTime? fromDate, DateTime? toDate, string category, string searchString)
        {
            var productsQuery = _context.Products.Include(p => p.User).AsQueryable();

            // Apply date range filter
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

            // Apply search filter
            if (!string.IsNullOrEmpty(searchString))
            {
                productsQuery = productsQuery.Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString));
            }

            var products = await productsQuery.ToListAsync();

            // Get list of categories for the filter dropdown
            ViewBag.Categories = await _context.Products.Select(p => p.Category).Distinct().ToListAsync();

            ViewBag.FromDate = fromDate;
            ViewBag.ToDate = toDate;
            ViewBag.Category = category;
            ViewBag.SearchString = searchString;

            return View(products);
        }

        // GET: Employee/ProductDetails/5
        public async Task<IActionResult> ProductDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }

}