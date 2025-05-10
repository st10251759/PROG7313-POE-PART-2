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

 Try Catch
 Author: w3schools
 Link: https://www.w3schools.com/cs/cs_exceptions.php
 Date Accessed: 08 May 2025

 Upload Image in MVC 
 Author: Aurigma
 Link: https://www.aurigma.com/upload-suite/developers/aspnet-mvc/how-to-upload-files-in-aspnet-mvc
 Date Accessed: 08 May 2025

 JavaScript
 Author: w3schools
 Link: https://www.w3schools.com/js/DEFAULT.asp
 Date Accessed: 08 May 2025

 JQuery
 Author: w3schools
 Link: https://www.w3schools.com/jquery/default.asp
 Date Accessed: 08 May 2025

 Regex Phone Number Validation
 Author: w3schools
 Link: https://www.w3schools.com/jquery/default.asp
 Date Accessed: 08 May 2025


==============================Code Attribution==================================

*/

// Required namespaces for ASP.NET Core MVC, Entity Framework Core, Identity, file handling, and security.
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ST10251759_PROG7313_POE_PART_2.Data;
using ST10251759_PROG7313_POE_PART_2.Models;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace ST10251759_PROG7313_POE_PART_2.Controllers
{
    // Only authenticated users with the "Farmer" role can access this controller
    [Authorize(Roles = "Farmer")]
    public class FarmerController : Controller
    {
        // Injected services for database context, user management, sign-in, and web host environment
        private readonly Prog7311DbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly SignInManager<IdentityUser> _signInManager;

        // Constructor to initialize the injected services
        public FarmerController(Prog7311DbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
        }

        // Displays all products owned by the currently logged-in farmer
        public async Task<IActionResult> Products()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get current user's ID
            var products = await _context.Products
                .Include(p => p.User) // Include user navigation property
                .Where(p => p.UserId == userId) // Filter products by current user
                .ToListAsync();

            return View(products);
        }

        // Shows the form to create a new product
        public IActionResult CreateProduct()
        {
            return View();
        }

        // Handles the submission of the product creation form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(Product product, Microsoft.AspNetCore.Http.IFormFile imageFile)
        {
            try
            {
                // Remove model validation for properties that will be set manually
                ModelState.Remove("UserId");
                ModelState.Remove("User");
                ModelState.Remove("ImageUrlPath");

                if (!ModelState.IsValid)
                {
                    return View(product); // Re-display the form with validation errors
                }

                // Associate the product with the currently logged-in user
                product.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // If an image is uploaded, process and save it
                if (imageFile != null && imageFile.Length > 0)
                {
                    var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images", "products");
                    if (!Directory.Exists(uploadsFolder))
                        Directory.CreateDirectory(uploadsFolder); // Ensure the folder exists

                    var uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(fileStream); // Save image to disk
                    }

                    product.ImageUrlPath = "/images/products/" + uniqueFileName; // Set image URL
                }
                else
                {
                    // Use a default image if none is uploaded
                    product.ImageUrlPath = "/images/products/default-product.jpg";
                }

                // Add product to database and save changes
                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Product created successfully!";
                return RedirectToAction(nameof(Products));
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                ModelState.AddModelError(string.Empty, $"Error creating product: {ex.Message}");
                return View(product);
            }
        }

        // Displays the product editing form for a specific product
        public async Task<IActionResult> EditProduct(int? id)
        {
            if (id == null)
                return NotFound();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var product = await _context.Products
                .Where(p => p.ProductId == id && p.UserId == userId)
                .FirstOrDefaultAsync();

            if (product == null)
                return NotFound();

            return View(product);
        }

        // Handles the form submission for editing a product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(int id, Product product, Microsoft.AspNetCore.Http.IFormFile imageFile)
        {
            if (id != product.ProductId)
                return NotFound();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (product.UserId != userId)
                return Unauthorized(); // Prevent editing products not owned by current user

            ModelState.Remove("User");
            ModelState.Remove("imageFile");

            if (ModelState.IsValid)
            {
                try
                {
                    var existingProduct = await _context.Products.FindAsync(id);
                    if (existingProduct == null)
                        return NotFound();

                    // Update relevant fields
                    existingProduct.Name = product.Name;
                    existingProduct.Description = product.Description;
                    existingProduct.Category = product.Category;
                    existingProduct.ProductionDate = product.ProductionDate;

                    // Handle image replacement
                    if (imageFile != null && imageFile.Length > 0)
                    {
                        var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images", "products");
                        if (!Directory.Exists(uploadsFolder))
                            Directory.CreateDirectory(uploadsFolder);

                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(fileStream);
                        }

                        // Delete old image if it is not the default
                        if (!string.IsNullOrEmpty(existingProduct.ImageUrlPath) &&
                            !existingProduct.ImageUrlPath.EndsWith("default-product.jpg"))
                        {
                            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath,
                                existingProduct.ImageUrlPath.TrimStart('/').Replace('/', Path.DirectorySeparatorChar));
                            if (System.IO.File.Exists(oldImagePath))
                                System.IO.File.Delete(oldImagePath);
                        }

                        existingProduct.ImageUrlPath = "/images/products/" + uniqueFileName;
                    }

                    _context.Update(existingProduct);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Product updated successfully!";
                    return RedirectToAction(nameof(Products));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                        return NotFound();
                    else
                        throw;
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, $"Error updating product: {ex.Message}");
                }
            }

            return View(product);
        }

        // Shows a confirmation page before deleting a product
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id == null)
                return NotFound();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var product = await _context.Products
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.ProductId == id && m.UserId == userId);

            if (product == null)
                return NotFound();

            return View(product);
        }

        // Handles the actual deletion of a product
        [HttpPost, ActionName("DeleteProduct")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteProductConfirmed(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id && m.UserId == userId);

            if (product == null)
                return NotFound();

            // Delete image from server if exists
            if (!string.IsNullOrEmpty(product.ImageUrlPath))
            {
                var imagePath = Path.Combine(_webHostEnvironment.WebRootPath,
                    product.ImageUrlPath.TrimStart('/').Replace('/', Path.DirectorySeparatorChar));
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Products));
        }

        // Displays the profile of the currently logged-in farmer
        public async Task<IActionResult> Profile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _context.ApplicationUsers.FindAsync(userId);

            if (user == null)
                return NotFound();

            // Pass any password update messages to the view
            if (TempData["PasswordChangeSuccess"] != null)
                ViewBag.PasswordChangeSuccess = TempData["PasswordChangeSuccess"].ToString();
            if (TempData["PasswordChangeError"] != null)
                ViewBag.PasswordChangeError = TempData["PasswordChangeError"].ToString();

            return View(user);
        }

        // Handles profile updates (except password)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateProfile(ApplicationUser user)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentUser = await _context.ApplicationUsers.FindAsync(userId);

            if (currentUser == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                currentUser.Firstname = user.Firstname;
                currentUser.Lastname = user.Lastname;
                currentUser.PhoneNumber = user.PhoneNumber;
                currentUser.Location = user.Location;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Profile));
            }

            return View("Profile", user);
        }

        // Checks if a product exists in the database
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        // Handles password update functionality
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePassword(string newPassword, string confirmPassword)
        {
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                TempData["PasswordChangeError"] = "All fields are required.";
                return RedirectToAction(nameof(Profile));
            }

            if (newPassword != confirmPassword)
            {
                TempData["PasswordChangeError"] = "The new password and confirmation password do not match.";
                return RedirectToAction(nameof(Profile));
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return NotFound();

            // Generate token and reset password
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, newPassword);

            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                TempData["PasswordChangeError"] = $"Failed to update password: {errors}";
                return RedirectToAction(nameof(Profile));
            }

            // Re-authenticate the user with the new password
            await _signInManager.SignInAsync(user, isPersistent: false);

            TempData["PasswordChangeSuccess"] = "Your password has been updated successfully.";
            return RedirectToAction(nameof(Profile));
        }
    }
}
