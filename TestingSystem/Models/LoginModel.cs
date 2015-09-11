using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestingSystem.Models
{
    /// <summary>
    /// Модель авторизации
    /// </summary>
    public class LoginModel
    {
        [Required]
        [DisplayName("Логин")]
        public string Login { get; set; }

        [Required]
        [DisplayName("Пароль")]
        public string Password { get; set; }



    }
}