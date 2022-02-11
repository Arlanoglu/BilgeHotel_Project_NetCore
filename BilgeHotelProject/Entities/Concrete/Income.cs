using Core.Entities;

namespace Entities.Concrete
{
    public class Income : BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public int RegistrationID { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
