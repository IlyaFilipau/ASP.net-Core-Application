using System.ComponentModel.DataAnnotations;

namespace WebApplication2.coursework
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Login not specified")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "The length of the string must be from 3 to 10 characters")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password not specified")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}