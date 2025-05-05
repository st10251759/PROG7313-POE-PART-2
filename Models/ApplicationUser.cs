using Microsoft.AspNetCore.Identity;

namespace ST10251759_PROG7313_POE_PART_2.Models
{
        public class ApplicationUser : IdentityUser
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }
    }