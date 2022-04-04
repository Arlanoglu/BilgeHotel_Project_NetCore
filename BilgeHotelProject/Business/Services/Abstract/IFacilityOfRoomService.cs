using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IFacilityOfRoomService : IService<FacilityOfRoom>
    {
        public IResult Create(List<FacilityOfRoom> models);
        public IResult RemoveForce(FacilityOfRoom model);
    }
}
