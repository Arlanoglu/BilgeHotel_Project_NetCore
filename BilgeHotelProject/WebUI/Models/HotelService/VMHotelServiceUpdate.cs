using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.HotelService
{
    public class VMHotelServiceUpdate
    {
        public int ServiceID { get; set; }
        public string IconPicture { get; set; }
        [Required(ErrorMessage = "Hizmet adı boş geçilemez.")]
        public string ServiceName { get; set; }
        [MaxLength(ErrorMessage = "En fazla 200 karakter girilmelidir.")]
        public string Description { get; set; }
    }
}
