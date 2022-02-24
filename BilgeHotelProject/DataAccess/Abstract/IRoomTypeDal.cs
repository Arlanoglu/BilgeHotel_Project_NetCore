using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IRoomTypeDal : IEntityRepository<RoomType>
    {
        List<RoomType> AvaibleRoomTypes(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople);
    }
}
