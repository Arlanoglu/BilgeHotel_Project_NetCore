﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IEmployeeService : IService<Employee>
    {
        public IResult ListUpdate(List<Employee> employees);
    }
}
