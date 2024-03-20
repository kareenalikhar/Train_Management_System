using System.ComponentModel.DataAnnotations;

namespace Train_Management_System.Models
{
    public class Login
    {
        // -- Validating Student Name  
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(12)]
        public string Name { get; set; }
        // -- Validating Email Address  
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        // -- Validating Contact Number  
        [Required(ErrorMessage = "Contact is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Contact { get; set; }
        // -- Validating Password
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password{get;set; }
        // -- Validating Confirm Password
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword{get;set;}
    }

}
