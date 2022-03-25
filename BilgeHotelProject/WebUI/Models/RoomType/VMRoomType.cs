using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models.RoomFacility;

namespace WebUI.Models.RoomType
{
    public class VMRoomType : BaseVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Oda tip adı boş bırakılamaz.")]
        public string RoomTypeName { get; set; }
        [Required(ErrorMessage = "Oda tipi ile ilgili açıklama bilgisi girmelisiniz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Kişi sayısı boş bırakılamaz.")]
        [Range(1,10,ErrorMessage ="Minimum 1 maximum 10 girilebilir.")]
        public int NumberOfPeople { get; set; }
        [Required(ErrorMessage = "Yatak sayısı boş bırakılamaz.")]
        [Range(1, 10, ErrorMessage = "Minimum 1 maximum 10 girilebilir.")]
        public int NumberOfBed { get; set; }
        [Required(ErrorMessage = "Fiyat bilgisi boş bırakılamaz.")]
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public Status Status { get; set; }

        public List<VMRoomPicture> VMRoomPictures { get; set; }
        public List<VMRoomFacility> VMRoomFacilities { get; set; }
    }
}
