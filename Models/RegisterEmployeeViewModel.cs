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
*/

/*

==============================Code Attribution==================================

 MVC APP
 Author: Microsoft
 Link: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-9.0&tabs=visual-studio
 Date Accessed: 06 May 2025

 Attributes
 Author: Simplilearn
 Link: https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/data-annotation-attributes-in-asp-dot-net-mvc
 Date Accessed: 06 May 2025

==============================Code Attribution==================================

*/

using System.ComponentModel.DataAnnotations;

namespace ST10251759_PROG7313_POE_PART_2.Models
{
    // This view model is used to capture and validate input from the user - Admin -  when registering a new employee.
    // It is separate from the main model and tailored for use in the registration form UI.

    public class RegisterEmployeeViewModel
    {
        // Stores the first name of the employee being registered.
        // The [Required] attribute ensures this field must be filled out in the form.
        // The [Display] attribute sets a user-friendly label for the UI form.
        [Required]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        // Stores the last name of the employee.
        // Also marked as required, and displayed with a friendly label in the UI.
        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        // Stores the email address of the employee.
        // Required for registration and validated with [EmailAddress] to ensure it has a valid email format.
        // Displayed with the label "Email" in the UI form.
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        // Stores the user's chosen password.
        // Required and constrained with a minimum length of 6 and a maximum of 100 characters.
        // The [DataType] attribute ensures the input is rendered as a password field (hiding the characters).
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        // Stores the user's confirmation of the password to ensure accuracy.
        // Also rendered as a password field in the UI.
        // The [Compare] attribute ensures that this value matches the Password field exactly.
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
