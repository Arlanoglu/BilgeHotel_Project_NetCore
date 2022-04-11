using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomType;
using WebUI.Models.ServicePack;

namespace WebUI.Models.Reservation
{
    public class VMWebReservation : BaseVM
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool Payment { get; set; }
        [Required(ErrorMessage ="İsim boş bırakılamaz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim boş bırakılamaz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Telefon boş bırakılamaz.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Eposta boş bırakılamaz.")]
        public string Email { get; set; }
        public string Description { get; set; }

        public int RoomID { get; set; }
        public int RoomTypeID { get; set; }
        public int ServicePackID { get; set; }
        public string AppUserID { get; set; }
    }
}
