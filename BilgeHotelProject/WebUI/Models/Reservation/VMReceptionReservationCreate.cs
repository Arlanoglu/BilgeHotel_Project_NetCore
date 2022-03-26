using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Reservation
{
    public class VMReceptionReservationCreate : BaseVM
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        [Required(ErrorMessage = "İsim boş bırakılamaz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim boş bırakılamaz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Telefon boş bırakılamaz.")]
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Eposta formatında giriş yapılmalıdır.")]
        public string Email { get; set; }
        [MaxLength(500,ErrorMessage = "En fazla 500 karakter girebilirsiniz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Fiyat bilgisi boş bırakılamaz.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Kişi sayısı boş bırakılamaz.")]
        [Range(1, 10, ErrorMessage = "Minimum 1 girilmelidir.")]
        public int NumberOfPeople { get; set; }
        public int RoomID { get; set; }
        public int RoomTypeID { get; set; }
        public int ServicePackID { get; set; }
    }
}
