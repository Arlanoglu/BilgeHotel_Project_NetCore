using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.HotelService
{
    public class VMHotelService : BaseVM
    {
        public int ServiceID { get; set; }
        public string IconPicture { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
