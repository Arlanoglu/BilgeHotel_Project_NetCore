using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFGuestRegistrationDal : EFBaseDal<GuestRegistration>, IGuestRegistrationDal
    {
        public EFGuestRegistrationDal(AppDbContext db) : base(db)
        {
        }
    }
}
