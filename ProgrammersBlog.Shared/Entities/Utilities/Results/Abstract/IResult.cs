using ProgrammersBlog.Shared.Entities.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Shared.Entities.Utilities.Results.Abstract
{
   public interface IResult
    {
        public ResultStatus ResultStatus { get;   }
        public string Message { get;   }
        public Exception  Exception { get;  }
    }
}
