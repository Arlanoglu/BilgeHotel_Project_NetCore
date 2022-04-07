using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Contact
{
    public class VMMessage : BaseVM
    {
        [Required(ErrorMessage ="İsim boş bırakılamaz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim boş bırakılamaz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Eposta boş bırakılamaz.")]
        [EmailAddress(ErrorMessage ="Eposta formatında giriş yapılmalı.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon numarası boş bırakılamaz.")]
        [Phone(ErrorMessage ="Telefon numarası formatında giriş yapılmalı.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Konu boş bırakılamaz.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Mesaj içeriği boş bırakılamaz.")]
        [MaxLength(500,ErrorMessage ="Maksimum 500 karakterde mesaj girilebilir.")]
        public string MessageContent { get; set; }

        public string AppUserID { get; set; }
    }
}
