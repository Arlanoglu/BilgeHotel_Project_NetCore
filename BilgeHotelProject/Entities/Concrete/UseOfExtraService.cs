using Core.Entities;

namespace Entities.Concrete
{
    public class UseOfExtraService : BaseEntity
    {
        public int Quantity { get; set; }
        public int ExtraServiceID { get; set; }
        public int RegistrationID { get; set; }
        public virtual ExtraService ExtraService { get; set; }
        public virtual Registration Registiration { get; set; }
    }
}
