using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ST10251759_PROG7313_POE_PART_2.Models
{
        public class ApplicationUser : IdentityUser
        {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }
    }
    }