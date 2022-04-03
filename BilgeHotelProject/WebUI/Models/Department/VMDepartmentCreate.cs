using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Department
{
    public class VMDepartmentCreate
    {
        [Required(ErrorMessage ="Departman adı boş bırakılamaz.")]
        public string DepartmentName { get; set; }
        [MaxLength(ErrorMessage ="En fazla 200 karakter girilebilir.")]
        public string Description { get; set; }
    }
}
