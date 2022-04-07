using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Aboutus
{
    public class VMAboutusUpdate
    {
        public int AboutusID { get; set; }
        [Required(ErrorMessage = "Başlık boş bırakılamaz.")]
        public string Title { get; set; }
        public string PictureUrl { get; set; }
        [Required(ErrorMessage = "En az 1 paragraf girilmelidir.")]
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter girilebilir.")]
        public string Paragraph1 { get; set; }
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter girilebilir.")]
        public string Paragraph2 { get; set; }
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter girilebilir.")]
        public string Paragraph3 { get; set; }
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter girilebilir.")]
        public string Paragraph4 { get; set; }
        [MaxLength(500, ErrorMessage = "En fazla 500 karakter girilebilir.")]
        public string Paragraph5 { get; set; }
    }
}
