using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomType;
using WebUI.Models.ServicePack;

namespace WebUI.Models.Registration
{
    public class VMRegistrationCreate : BaseVM
    {
        [Required(ErrorMessage = "İsim boş bırakılamaz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim boş bırakılamaz.")]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Eposta formatında giriş yapılmalıdır.")]
        public string Email { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter girebilirsiniz.")]
        public string Description { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }
        public RegistrationType RegistrationType { get; set; }
        public RegistrationStatus RegistrationStatus { get; set; }
        public int ReservationID { get; set; }

        public int RoomID { get; set; }
        public int RoomTypeID { get; set; }
        public int ServicePackID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomTypeName { get; set; }
        public string ServicePackName { get; set; }

        public List<VMRoomType> VMRoomTypes { get; set; }
        public List<VMServicePack> VMServicePacks { get; set; }
    }
}
