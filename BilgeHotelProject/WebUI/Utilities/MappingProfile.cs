﻿using AutoMapper;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.Contact;
using WebUI.Models.HomePage;
using WebUI.Models.RoomType;

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
        }
    }
}
