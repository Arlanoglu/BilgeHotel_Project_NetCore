using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Income
{
    public class VMIncome
    {
        public int IncomeID { get; set; }
        public DateTime IncomeDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int RegistrationID { get; set; }
    }
}
