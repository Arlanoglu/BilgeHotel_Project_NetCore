using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ServicePack
{
    public class VMServicePackList : BaseVM
    {
        public int ServicePackID { get; set; }
        public string PackName { get; set; }
        public decimal PackPrice { get; set; }
        public Status Status { get; set; }
    }
}
