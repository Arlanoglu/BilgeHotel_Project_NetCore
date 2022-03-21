using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;
using WebUI.Models.Aboutus;
using WebUI.Models.Contact;
using WebUI.Models.HomePage;
using WebUI.Models.HotelService;
using WebUI.Models.Picture;
using WebUI.Models.Reservation;
using WebUI.Models.RoomFacility;
using WebUI.Models.RoomType;
using WebUI.Models.StatusOfRoom;
using WebUI.Utilities.Enums;

namespace WebUI.Utilities
{
    public class ObjectCreator
    {
        public BaseVM FactoryMethod(ViewModels viewModelType)
        {
            BaseVM viewModel = null;
            switch (viewModelType)
            {
                case ViewModels.VMAboutus:
                    viewModel = new VMAboutus();
                    break;
                case ViewModels.VMContact:
                    viewModel = new VMContact();
                    break;
                case ViewModels.VMSocialMedia:
                    viewModel = new VMSocialMedia();
                    break;
                case ViewModels.VMHomePage:
                    viewModel = new VMHomePage();
                    break;
                case ViewModels.VMHomePageSlide:
                    viewModel = new VMHomePageSlide();
                    break;
                case ViewModels.VMHotelService:
                    viewModel = new VMHotelService();
                    break;
                case ViewModels.VMPicture:
                    viewModel = new VMPicture();
                    break;
                case ViewModels.VMRoomFacility:
                    viewModel = new VMRoomFacility();
                    break;
                case ViewModels.VMRoomPicture:
                    viewModel = new VMRoomPicture();
                    break;
                case ViewModels.VMRoomType:
                    viewModel = new VMRoomType();
                    break;
                case ViewModels.VMRoomTypeName:
                    viewModel = new VMRoomTypeName();
                    break;
                case ViewModels.VMHomeIndex:
                    viewModel = new VMHomeIndex();
                    break;
                case ViewModels.VMWebReservation:
                    viewModel = new VMWebReservation();
                    break;
                case ViewModels.VMReservation:
                    viewModel = new VMReservation();
                    break;
                case ViewModels.VMStatusOfRoom:
                    viewModel = new VMStatusOfRoom();
                    break;
            }
            return viewModel;
        }
    }
}
