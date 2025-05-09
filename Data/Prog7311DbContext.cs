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

MVC ASP.NET App connected to local SSMS Database
Author: Andy Malone MVP
Link: https://www.youtube.com/watch?app=desktop&v=ZX12X-ALwGA
Date Accessed: 05 May 2025


==============================Code Attribution==================================

*/

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ST10251759_PROG7313_POE_PART_2.Models;

namespace ST10251759_PROG7313_POE_PART_2.Data
{
    // This class defines the application's database context and inherits from IdentityDbContext,
    // which provides all the necessary tables and functionality to manage users, roles, logins, etc.
    // By inheriting from IdentityDbContext instead of DbContext, we integrate Microsoft Identity directly into our database.

    public class Prog7311DbContext : IdentityDbContext
    {
        // Constructor that receives configuration options and passes them to the base class (IdentityDbContext).
        // These options are usually provided in the Startup.cs or Program.cs file when configuring services.
        public Prog7311DbContext(DbContextOptions<Prog7311DbContext> options) : base(options)
        {
        }

        // Represents the ApplicationUsers table in the database.
        // Although IdentityDbContext already manages user entities,
        // this allows you to extend IdentityUser (as done in ApplicationUser) and access those extended properties (e.g., Firstname, Lastname).
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        // Represents the Products table in the database.
        // Each Product record is stored in this table, and the model's properties map to the table's columns.
        public DbSet<Product> Products { get; set; }
    }
}
