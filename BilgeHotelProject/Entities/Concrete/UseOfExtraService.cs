using Core.Entities;

namespace Entities.Concrete
{
    public class UseOfExtraService : BaseEntity
    {
        public int Number { get; set; } //Todo: Adet ingilizcesine tekrar bak
        public int ExtraServiceID { get; set; }
        public int RegistrationID { get; set; }
        public virtual ExtraService ExtraService { get; set; }
        public virtual Registration Registiration { get; set; }
    }
}
