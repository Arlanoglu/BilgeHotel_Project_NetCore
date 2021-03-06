using Entities.Abstract;
using Core.Entities;
using System;
using Entities.Enum;

namespace Entities.Concrete
{
    public class WebReservation : BaseEntity, IBaseReservation
    {
        public WebReservation()
        {
            ReservationDate = DateTime.Now;
            ReservationStatus = ReservationStatus.RezervasyonAlindi;
            ReservationType = ReservationType.Web;
        }
        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }

        //private decimal _price;
        //public decimal Price 
        //{
        //    get
        //    {
        //        var numberOfDays = (CheckOutDate.Date - CheckInDate.Date).TotalDays;
        //        if (numberOfDays!=0)
        //        {
        //            _price = _price * decimal.Parse(numberOfDays.ToString());
        //        }
        //        return _price;
        //    }
        //    set
        //    {
        //        _price = value;
        //    }
        //}//Nerede doldurulacak karar verilmedi
        public decimal DiscountedPrice { get; set; }
        public bool Payment { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public ReservationStatus ReservationStatus { get; set; }       
        public ReservationType ReservationType { get; set; }       

        public int RoomID { get; set; }
        public int? RoomTypeID { get; set; }
        public int ServicePackID { get; set; }
        public string AppUserID { get; set; }
        public virtual Room Room { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ServicePack ServicePack { get; set; }
        public virtual AppUser AppUser { get; set; }

        
    }
}
