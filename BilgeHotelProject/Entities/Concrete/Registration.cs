using Core.Entities;
using Entities.Enum;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Registration : BaseEntity
    {
        public Registration()
        {
            RegistrationStatus = RegistrationStatus.GirisYapildi;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        //public string RegistrationType { get; set; }
        public string Description { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }
        public RegistrationType RegistrationType { get; set; }
        public RegistrationStatus RegistrationStatus { get; set; }
        //Todo: Giriş saati farketmeksizin 14:00 olacaktır. Map işleminde yazıldı kontrol edilecek.
        public int? ReservationID { get; set; }

        public int RoomID { get; set; }
        public int ServicePackID { get; set; }
        public virtual Room Room { get; set; }
        public virtual ServicePack ServicePack { get; set; }
        public virtual ICollection<GuestRegistration> GuestRegistrations { get; set; }
        public virtual ICollection<UseOfExtraService> UseOfExtraServices { get; set; } //Unutulmuş yeni eklendi.
    }
}
