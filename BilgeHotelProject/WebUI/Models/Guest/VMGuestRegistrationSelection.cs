using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Guest
{
    public class VMGuestRegistrationSelection : BaseVM
    {
        public int RegistrationID { get; set; }
        public List<VMGuestList> VMGuestLists { get; set; }
    }
}
