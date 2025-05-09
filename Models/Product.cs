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


==============================Code Attribution==================================

*/

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST10251759_PROG7313_POE_PART_2.Models
{
    // Represents a product within the application, such as one created or managed by a farmer or employee.
    // This model is linked to a user via a foreign key and includes validation attributes to enforce required fields.
    public class Product
    {
        // Primary key for the Product table.
        // The [Key] attribute specifies that this property uniquely identifies a record.
        public int ProductId { get; set; }

        // Stores the name of the product.
        // The [Required] attribute ensures that the user cannot submit the form without providing a name.
        // The [Display] attribute specifies the label to show in forms and UI.
        [Required(ErrorMessage = "Product name is required")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        // A textual description of the product's characteristics or purpose.
        // Required for form submission and also labeled appropriately in the UI.
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        // Indicates the category or type of product (e.g., vegetables, dairy).
        // This field is required to ensure categorization for filtering or reporting.
        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        // The date on which the product was produced or harvested.
        // Required for traceability and expiration tracking.
        // The [DataType] attribute instructs the UI to render an appropriate date picker.
        [Required(ErrorMessage = "Production date is required")]
        [Display(Name = "Production Date")]
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }

        // Holds the file path or URL of the product's image.
        // Not required, so users may choose not to upload an image.
        // The [Display] attribute customizes the label shown in forms.
        [Display(Name = "Image")]
        public string ImageUrlPath { get; set; }

        // Stores the ID of the user (typically a farmer or employee) who created this product.
        // This property will be set programmatically in the controller based on the logged-in user's identity.
        public string UserId { get; set; }

        // Navigation property to associate the product with a specific application user.
        // The [ForeignKey] attribute explicitly defines UserId as the foreign key for this relationship.
        // Marked as virtual to enable lazy loading if supported.
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}
