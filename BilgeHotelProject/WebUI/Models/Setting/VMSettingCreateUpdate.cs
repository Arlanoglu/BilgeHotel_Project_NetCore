using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Setting
{
    public class VMSettingCreateUpdate
    {
        public int SettingID { get; set; }
        [Required(ErrorMessage ="SmtpHost alanı boş bırakılamaz.")]
        public string SmtpHost { get; set; }
        [Range(1, 1000, ErrorMessage = "Minimum 1 girilmelidir.")]
        public int SmtpPort { get; set; }
        [Required(ErrorMessage = "SmtpEmail alanı boş bırakılamaz.")]
        public string SmtpEmail { get; set; }
        [Required(ErrorMessage = "SmtpPassword alanı boş bırakılamaz.")]
        public string SmtpPassword { get; set; }
    }
}
