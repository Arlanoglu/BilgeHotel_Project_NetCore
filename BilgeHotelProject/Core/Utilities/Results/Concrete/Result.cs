using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public ResultStatus ResultStatus { get ; set ; }
        public string Message { get ; set ; }
        public Exception Exception { get ; set ; }
    }
}
