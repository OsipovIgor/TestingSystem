using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestingSystem.Models
{
    public class LoginModel
    {
        [Required]
        [DisplayName("Логин")]
        public string Login { get; set; }

        [Required]
        [DisplayName("Пароль")]
        public string Password { get; set; }

        [DisplayName("Запомнить")]
        public bool RememberMe { get; set; }


    }
}