using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Shift
{
    public class VMShiftCreate : BaseVM
    {
        [Required(ErrorMessage ="Vardiya adı boş bırakılamaz.")]
        public string ShiftName { get; set; }
        [Required(ErrorMessage = "Başlangıç saati boş bırakılamaz.")]
        public TimeSpan StartTime { get; set; }
        [Required(ErrorMessage = "Bitiş saati boş bırakılamaz.")]
        public TimeSpan EndTime { get; set; }
        [MaxLength(ErrorMessage ="En fazla 500 karakter girilebilir.")]
        public string Description { get; set; }
    }
}
