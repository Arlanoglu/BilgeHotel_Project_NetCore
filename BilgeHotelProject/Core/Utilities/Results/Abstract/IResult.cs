using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
