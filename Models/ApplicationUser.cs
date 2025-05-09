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
Date Accessed: 05 May 2025

==============================Code Attribution==================================

*/

//Import List

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ST10251759_PROG7313_POE_PART_2.Models
{
    /// The ApplicationUser class extends the built-in IdentityUser class to include 
    /// additional properties relevant to this application's domain (e.g., Firstname, Lastname, Location).
    /// This class represents a user in the system and is used by ASP.NET Core Identity for authentication and authorization.
    public class ApplicationUser : IdentityUser
    {
        /// Stores the user's first name. This field is required.
        [Required]
        public string Firstname { get; set; }

        /// Stores the user's last name. This field is required.
        [Required]
        public string Lastname { get; set; }

        /// Stores the user's physical location. 
        /// The [Display] attribute changes the label name in UI forms and views to "Location".
        [Display(Name = "Location")]
        public string Location { get; set; }
    }
}
