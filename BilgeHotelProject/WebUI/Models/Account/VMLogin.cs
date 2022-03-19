using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Account
{
    public class VMLogin : BaseVM
    {
        [Required(ErrorMessage ="Email zorunlu.")]
        [EmailAddress(ErrorMessage ="Email formatında giriş yapılmalı.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Şifre zorunlu.")]
        public string Password { get; set; }
    }
}
