using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IRoomService : IService<Room>
    {
        Task<List<Room>> AvaibleRooms(DateTime checkinDate, DateTime checkoutDate, int numberOfPeople);
    }
}
