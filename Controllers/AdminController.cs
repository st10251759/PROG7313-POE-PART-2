// Controllers/AdminController.cs

using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using ST10251759_PROG7313_POE_PART_2.Data;

using ST10251759_PROG7313_POE_PART_2.Models;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Threading.Tasks;

namespace ST10251759_PROG7313_POE_PART_2.Controllers

{

    [Authorize(Roles = "Admin")]

    public class AdminController : Controller

    {

        private readonly Prog7311DbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(Prog7311DbContext context, UserManager<IdentityUser> userManager,

            RoleManager<IdentityRole> roleManager)

        {

            _context = context;

            _userManager = userManager;

            _roleManager = roleManager;

        }

        // GET: Admin/Employees

        public async Task<IActionResult> Employees()

        {

            var employeeRoleId = await _roleManager.FindByNameAsync("Employee");

            if (employeeRoleId == null)

                return View(new List<ApplicationUser>());

            var employeesQuery = from user in _context.ApplicationUsers

                                 join userRole in _context.UserRoles on user.Id equals userRole.UserId

                                 where userRole.RoleId == employeeRoleId.Id

                                 select user;

            var employees = await employeesQuery.ToListAsync();

            return View(employees);

        }

        // GET: Admin/CreateEmployee

        public IActionResult CreateEmployee()

        {

            return View();

        }

        // POST: Admin/CreateEmployee

        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CreateEmployee(RegisterEmployeeViewModel model)

        {

            if (ModelState.IsValid)

            {

                var user = new ApplicationUser

                {

                    UserName = model.Email,

                    Email = model.Email,

                    Firstname = model.Firstname,

                    Lastname = model.Lastname

                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)

                {

                    await _userManager.AddToRoleAsync(user, "Employee");

                    return RedirectToAction(nameof(Employees));

                }

                foreach (var error in result.Errors)

                {

                    ModelState.AddModelError(string.Empty, error.Description);

                }

            }

            return View(model);

        }

        // GET: Admin/DeleteEmployee/5

        public async Task<IActionResult> DeleteEmployee(string id)

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

            // Check if the user is actually an employee

            var isInRole = await _userManager.IsInRoleAsync(user, "Employee");

            if (!isInRole)

            {

                return NotFound();

            }

            return View(user);

        }

        // POST: Admin/DeleteEmployee/5

        [HttpPost, ActionName("DeleteEmployee")]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteEmployeeConfirmed(string id)

        {

            var user = await _context.ApplicationUsers.FindAsync(id);

            if (user == null)

            {

                return NotFound();

            }

            // Check if the user is actually an employee

            var isInRole = await _userManager.IsInRoleAsync(user, "Employee");

            if (!isInRole)

            {

                return NotFound();

            }

            // Delete the user

            await _userManager.DeleteAsync(user);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Employees));

        }

    }

    

}
