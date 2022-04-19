using System.ComponentModel.DataAnnotations;

namespace FinalCalculatorSandeep.Models
{
    public class Login
    {

        [Required(ErrorMessage = "Please Enter Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

       

        [Required(ErrorMessage = "Please Enter Email...")]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
