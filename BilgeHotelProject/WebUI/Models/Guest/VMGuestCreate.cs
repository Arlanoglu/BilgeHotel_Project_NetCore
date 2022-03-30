using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Guest
{
    public class VMGuestCreate : BaseVM
    {
        [Required(ErrorMessage ="İsim boş bırakılamaz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim boş bırakılamaz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Kimlik bilgisi boş bırakılamaz.")]
        public string IdentificationNumber { get; set; }
        [Required(ErrorMessage = "Adres boş bırakılamaz.")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Ülke boş bırakılamaz.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Telefon numarası boş bırakılamaz.")]
        [Phone(ErrorMessage = "Telefon numarası formatında bir giriş yapılmalıdır.")]
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Eposta formatında bir giriş yapılmalıdır.")]
        public string Email { get; set; }
        public string IdCardFrontSideImage { get; set; }
        public string IdCardBackSideImage { get; set; }
    }
}
