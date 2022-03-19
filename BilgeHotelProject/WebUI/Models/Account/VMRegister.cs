using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Account
{
    public class VMRegister : BaseVM
    {
        [Required(ErrorMessage ="İsim zorunlu.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim zorunlu.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Telefon zorunlu.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email zorunlu.")]
        [EmailAddress(ErrorMessage ="Email formatında giriş yapılmalı.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre zorunlu.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar zorunlu.")]
        [Compare("Password",ErrorMessage ="Şifre ve şifre tekrar aynı olmalıdır.")]
        public string ConfirmPassword { get; set; }
    }
}
