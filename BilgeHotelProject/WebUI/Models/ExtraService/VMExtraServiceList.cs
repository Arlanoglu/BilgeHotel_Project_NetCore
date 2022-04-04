using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ExtraService
{
    public class VMExtraServiceList
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage ="Hizmet ismi boş bırakılamaz.")]
        public string ServiceName { get; set; }
        [Required(ErrorMessage = "Fiyat boş bırakılamaz.")]
        [DataType(DataType.Currency, ErrorMessage ="Fiyat alanına parasal bir ifade girilmelidir.")]
        public decimal Price { get; set; }
        public Status Status { get; set; }
    }
}
