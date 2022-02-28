using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IRoomTypeService : IService<RoomType>
    {
        Task<List<RoomType>> AvaibleRoomTypes(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople);
    }
}
