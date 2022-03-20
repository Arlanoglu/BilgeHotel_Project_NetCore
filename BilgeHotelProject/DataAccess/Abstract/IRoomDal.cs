using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRoomDal : IEntityRepository<Room> 
    {
        Task<List<Room>> AvaibleRooms(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople);
    }
}
