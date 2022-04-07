using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Income : BaseEntity
    {
        public Income()
        {
            IncomeDate = DateTime.Now;
        }
        public DateTime IncomeDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int RegistrationID { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
