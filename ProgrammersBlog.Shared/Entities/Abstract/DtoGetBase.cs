﻿using ProgrammersBlog.Shared.Entities.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Shared.Entities.Abstract
{
  public abstract  class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }

    }
}
