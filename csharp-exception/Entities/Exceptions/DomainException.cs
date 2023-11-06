﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception.Entities.Exceptions
{
    internal class DomainException: ApplicationException
    {
        public DomainException(string message): base(message) { }
    }
}