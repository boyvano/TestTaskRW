using System.ComponentModel.DataAnnotations;

namespace TestTaskRW.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "логин (никнейм)")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
