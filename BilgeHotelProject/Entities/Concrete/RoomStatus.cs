﻿using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class RoomStatus : BaseEntity
    {
        public string StatusName { get; set; }

        public virtual List<StatusOfRoom> StatusOfRooms { get; set; }
    }
}
