using Core.Entities;

namespace Entities.Concrete
{
    public class Picture : BaseEntity
    {
        public string PictureName { get; set; }
        public string PictureUrl { get; set; }

        public int AboutusID { get; set; }
        public virtual Aboutus Aboutus { get; set; }
    }
}
