using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface IUseOfExtraServiceService : IService<UseOfExtraService>
    {
        IResult RemoveForce(UseOfExtraService model);
        IResult RemoveForceList(List<UseOfExtraService> modelList);
        IResult UpdateSelf(UseOfExtraService model);
    }
}
