using System.ComponentModel.DataAnnotations;
namespace WebApplication2.coursework
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Login not specified")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "The length of the string must be from 3 to 10 characters")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Email not specified")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email entered incorrectly")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password not specified")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password entered incorrectly")]
        public string ConfirmPassword { get; set; }
    }
}
//public int IdCustomer { get; set; }
//[Required(ErrorMessage = "Не указано имя")]
//[StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
//public string CustomerLogin { get; set; }
//[Required(ErrorMessage = "Не указан пароль")]
//public string CustomerPassword { get; set; }
//[Required(ErrorMessage = "Не указан электронный адрес")]
////[EmailAddress(ErrorMessage = "Некорректный адрес")]
//[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
//public string CustomerEmail { get; set; }