using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Worker
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите фамилию")]
        [Display(Name = "Фамилия")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string LastName { get; set; }

        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Введите адрес электронной почты")]
        [Display(Name = "Адрес электронной почты")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Выберите район")]
        [Display(Name = "Район")]
        public string Area { get; set; }

        [Required(ErrorMessage = "Выберите сферу деятельности")]
        [Display(Name = "Сфера деятельности")]
        public string CategoryServises { get; set; }

        [Required(ErrorMessage = "Выберите услугу")]
        [Display(Name = "Услуги")]
        public string CategoryWork { get; set; }

        [Display(Name = "Фото профиля")]
        public string PhotoProfile { get; set; }

        [Display(Name = "Фото примеров работ")]
        public string PhotoWorks { get; set; }

        [Required(ErrorMessage = "Введите имя пользователя")]
        [Display(Name = "Имя пользователя" )]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
