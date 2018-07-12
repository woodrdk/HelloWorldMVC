using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloWorldMVC.Models
{
    public class Student
    {
        [Required(ErrorMessage = "ID Required")]
        [Display(Name = "Student Id")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "SID must be 9 digits")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "First Name Required")] 
        [Display(Name = "First Name")]
        [StringLength(25, ErrorMessage = "This must be 1 - 25 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "This must be 1 - 50 characters")]
        public string LastName { get; set; }

        // value types are implicitly required because they have to have a value
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
    }
}