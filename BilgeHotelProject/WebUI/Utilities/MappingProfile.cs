using AutoMapper;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Aboutus;
using WebUI.Models.Contact;
using WebUI.Models.HomePage;
using WebUI.Models.Picture;
using WebUI.Models.RoomType;
using WebUI.Models.HotelService;
using WebUI.Models.RoomFacility;
using WebUI.Models.Reservation;
using WebUI.Models.ServicePack;
using WebUI.Models.Account;
using WebUI.Models.StatusOfRoom;

namespace WebUI.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HomePage, VMHomePage>();
            CreateMap<VMHomePage, HomePage>();

            CreateMap<HomePageSlide, VMHomePageSlide>();
            CreateMap<VMHomePageSlide, HomePageSlide>();

            CreateMap<RoomType, VMRoomType>();
            CreateMap<VMRoomType, RoomType>();
            CreateMap<VMRoomTypeName, RoomType>();
            CreateMap<RoomType, VMRoomTypeName>();
            CreateMap<RoomPicture, VMRoomPicture>();
            CreateMap<VMRoomPicture, RoomPicture>();

            CreateMap<Contact, VMContact>();
            CreateMap<VMContact, Contact>();
            CreateMap<VMSocialMedia, Contact>();
            CreateMap<Contact, VMSocialMedia>();

            CreateMap<Aboutus, VMAboutus>();
            CreateMap<VMAboutus, Aboutus>();

            CreateMap<Picture, VMPicture>();
            CreateMap<VMPicture, Picture>();

            CreateMap<HotelService, VMHotelService>();
            CreateMap<VMHotelService, HotelService>();

            CreateMap<VMRoomFacility, RoomFacility>();
            CreateMap<RoomFacility, VMRoomFacility>();

            CreateMap<WebReservation, VMWebReservation>();
            CreateMap<VMWebReservation, WebReservation>();

            CreateMap<ServicePack, VMServicePack>();
            CreateMap<VMServicePack, ServicePack>();

            CreateMap<AppUser, VMLogin>();
            CreateMap<VMLogin, AppUser>();

            CreateMap<VMRegister, AppUser>();
            CreateMap<AppUser, VMRegister>();

            CreateMap<AppUser, VMUserSession>();
            CreateMap<VMUserSession, AppUser>();

            CreateMap<VMReservation, VMWebReservation>();
            CreateMap<VMWebReservation, VMReservation>();

            CreateMap<VMStatusOfRoom, StatusOfRoom>();
            CreateMap<StatusOfRoom, VMStatusOfRoom>();

            CreateMap<VMMyReservation, WebReservation>();
            CreateMap<WebReservation, VMMyReservation>();

            CreateMap<Message, VMMessage>();
            CreateMap<VMMessage, Message>();

            CreateMap<VMReservationList, WebReservation>();
            CreateMap<WebReservation, VMReservationList>().ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.RoomType.RoomTypeName));
            CreateMap<ReceptionReservation, VMReservationList>().ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.RoomType.RoomTypeName));
            CreateMap<VMReservationList, ReceptionReservation>();

            CreateMap<VMReservationDetail, WebReservation>();
            CreateMap<WebReservation, VMReservationDetail>()
                .ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.RoomType.RoomTypeName))
                .ForMember(x => x.ServicePackName, w => w.MapFrom(y => y.ServicePack.PackName))
                .ForMember(x => x.RoomNumber, w => w.MapFrom(y => y.Room.RoomNumber))
                .ForMember(x => x.AppUserEmail, w => w.MapFrom(y => y.AppUser.Email))
                .ForMember(x => x.AppUserFullName, w => w.MapFrom(y => y.AppUser.FirstName +" "+ y.AppUser.LastName));
            CreateMap<ReceptionReservation, VMReservationDetail>()
                .ForMember(x => x.RoomTypeName, w => w.MapFrom(y => y.RoomType.RoomTypeName))
                .ForMember(x => x.ServicePackName, w => w.MapFrom(y => y.ServicePack.PackName))
                .ForMember(x => x.RoomNumber, w => w.MapFrom(y => y.Room.RoomNumber));
            CreateMap<VMReservationDetail, ReceptionReservation>();

            CreateMap<VMReceptionReservationCreate, ReceptionReservation>();
            CreateMap<ReceptionReservation, VMReceptionReservationCreate>();

            CreateMap<VMReservation, VMReceptionReservationCreate>();
            CreateMap<VMReceptionReservationCreate, VMReservation>();
        }
    }
}
