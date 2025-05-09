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

namespace ST10251759_PROG7313_POE_PART_2.Models
{
    // The ErrorViewModel class is used to represent error-related information 
    // that can be passed from the controller to the error view in the application.
    public class ErrorViewModel
    {
        // Holds the unique ID of the request that caused the error.
        // This is helpful for tracing issues, especially when logging or debugging errors.
        // The "?" allows the string to be nullable.
        public string? RequestId { get; set; }

        // A computed property that determines whether the RequestId should be displayed.
        // Returns true only if RequestId is not null or empty.
        // This is typically used in the error view to conditionally show the request ID to the user.
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

