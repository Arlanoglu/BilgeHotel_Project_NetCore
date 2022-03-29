using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ExtraService
{
    public class VMExtraService : BaseVM
    {
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
    }
}
