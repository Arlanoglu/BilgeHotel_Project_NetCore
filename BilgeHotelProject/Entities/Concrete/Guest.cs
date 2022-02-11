using Core.Entities;

namespace Entities.Concrete
{
    public class Guest : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string IdCardFrontSideImage { get; set; }
        public string IdCardBackSideImage { get; set; }
        public int RegistrationID { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
