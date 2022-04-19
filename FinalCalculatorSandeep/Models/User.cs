using System;
using System.ComponentModel.DataAnnotations;

namespace FinalCalculatorSandeep.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Enter Username..")]
        [Display(Name = "UserName")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter the Confirm Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Enter Email...")]               
        [Display(Name = "Email")]
        public string Email { get; set; }

    }


    public class CalcHistory
    {
        [Key]
       
        [Display(Name = "Data")]
        public string Data { get; set; }


        [Display(Name = "Result")]
        public string Result { get; set; }

       
        [Display(Name = "RDate")]
        public DateTime RDate { get; set; }

    }
}
