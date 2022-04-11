using Core.Entities.Enum;
using System;

namespace Core.Entities
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public Status Status { get; set; }

        public DateTime? CreatedDate { get; set; }
        //public string CreatedComputerName { get; set; }
        //public string CreatedIP { get; set; }
        //public string CreatedUserName { get; set; }
        //public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
        //public string ModifiedComputerName { get; set; }
        //public string ModifiedUsername { get; set; }
        //public string ModifiedIP { get; set; }
        //public string ModifiedBy { get; set; }
    }
}
