using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Contact
{
    public class VMContactCreateUpdate
    {
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Adres alanı boş bırakılamaz.")]
        [MaxLength(ErrorMessage = "En fazla 200 karakter girilebilir.")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Adres alanı boş bırakılamaz.")]
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        [Required(ErrorMessage = "Adres alanı boş bırakılamaz.")]
        public string Email { get; set; }
        [MaxLength(ErrorMessage = "En fazla 200 karakter girilebilir.")]
        public string Facebook { get; set; }
        [MaxLength(ErrorMessage = "En fazla 200 karakter girilebilir.")]
        public string Instagram { get; set; }
        [MaxLength(ErrorMessage = "En fazla 200 karakter girilebilir.")]
        public string Twitter { get; set; }
    }
}
