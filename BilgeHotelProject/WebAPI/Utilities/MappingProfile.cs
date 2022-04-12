using AutoMapper;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Guest;

namespace WebAPI.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Guest, GuestListModel>()
                .ForMember(x => x.IdCardBackSideImage, w => w.MapFrom(x => "https://localhost:44321" + x.IdCardBackSideImage))
                .ForMember(x => x.IdCardFrontSideImage, w => w.MapFrom(x => "https://localhost:44321" + x.IdCardFrontSideImage));
            CreateMap<GuestListModel, Guest>();
        }
    }
}
