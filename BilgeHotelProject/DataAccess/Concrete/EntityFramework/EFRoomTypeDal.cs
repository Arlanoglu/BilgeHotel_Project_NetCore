using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRoomTypeDal : EFBaseDal<RoomType>, IRoomTypeDal
    {
        private readonly AppDbContext db;

        public EFRoomTypeDal(AppDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
