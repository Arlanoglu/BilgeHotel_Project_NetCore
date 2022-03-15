using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ServicePack
{
    public class VMServicePack : BaseVM
    {
        public int ID { get; set; }
        public string PackName { get; set; }
        public decimal PackPrice { get; set; }
        public string Description { get; set; }
    }
}
