using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ExtraService
{
    public class VMUseOfExtraServiceCreate : BaseVM
    {
        public int Quantity { get; set; }
        public int ExtraServiceID { get; set; }
        public int RegistrationID { get; set; }
    }
}
