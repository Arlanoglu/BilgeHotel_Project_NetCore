using Core.Entities.Enum;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.ExtraService;
using WebUI.Models.Guest;

namespace WebUI.Models.Registration
{
    public class VMRegistrationDetail
    {
        public int ID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        private decimal _extraServiceTotalPrice;
        public decimal ExtraServiceTotalPrice 
        {
            get 
            {
                _extraServiceTotalPrice = 0;
                if (VMExtraServices.Count>0)
                {
                    foreach (var item in VMExtraServices)
                    {
                        _extraServiceTotalPrice += item.TotalPrice;
                    }
                }
                return _extraServiceTotalPrice;
            } 
        }
        private decimal _totalPrice;
        public decimal TotalPrice
        {
            get
            {
                _totalPrice = 0;
                _totalPrice = _totalPrice + Price;
                return _totalPrice;
            }
        }
        public string Description { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }
        public RegistrationType RegistrationType { get; set; }
        public RegistrationStatus RegistrationStatus { get; set; }
        public Status Status { get; set; }
        public int ReservationID { get; set; }

        public int RoomID { get; set; }
        public int ServicePackID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomTypeName { get; set; }
        public string ServicePackName { get; set; }
        public List<VMGuestRegistrationList> VMGuests { get; set; }
        public List<VMExtraService> VMExtraServices { get; set; }
    }
}
