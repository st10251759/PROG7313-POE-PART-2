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
    // This view model is specifically designed to capture input data when registering a new farmer.
    // It includes all required personal and contact information fields, and enforces validation rules using data annotations.

    public class RegisterFarmerViewModel
    {
        // Stores the first name of the farmer.
        // Marked as required to ensure the user cannot proceed without providing a name.
        // The [Display] attribute sets the label shown in the UI form.
        [Required]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        // Stores the last name of the farmer.
        // Also required, ensuring every registered farmer has both a first and last name.
        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        // Stores the email address of the farmer.
        // Required for registration and communication.
        // Validated using [EmailAddress] to ensure correct format (e.g., name@example.com).
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        // Stores the farmer's phone number.
        // Required for contact purposes.
        // Validated with [Phone] to ensure a valid phone number format is provided.
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        // Stores the physical or geographical location of the farmer (e.g., farm location or residence).
        // Required for logistical and operational needs, such as product origin tracking or delivery.
        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; }

        // Stores the farmer's chosen password for authentication.
        // Required and constrained to a minimum of 6 characters and a maximum of 100.
        // The error message will provide context if the length is not within the required range.
        // Rendered as a password field in the UI to mask characters.
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        // Stores the confirmation entry of the password to prevent input mistakes.
        // Also rendered as a masked password field.
        // Uses [Compare] to ensure it matches the Password field exactly.
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
