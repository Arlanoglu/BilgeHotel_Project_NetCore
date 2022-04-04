using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ServicePack
{
    public class VMServicePackCreate : BaseVM
    {
        [Required(ErrorMessage = "Paket adı boş bırakılamaz.")]
        public string PackName { get; set; }
        [Required(ErrorMessage = "Fiyat boş bırakılamaz.")]
        [DataType(DataType.Currency, ErrorMessage = "Fiyat alanına parasal bir ifade girilmelidir.")]
        public decimal PackPrice { get; set; }
        public string Description { get; set; }
    }
}
