﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ExtraService : BaseEntity
    {
        public string ServiceName { get; set; }
        public decimal Price { get; set; }

        public virtual List<UseOfExtraService> UseOfExtraServices { get; set; }
    }
}
