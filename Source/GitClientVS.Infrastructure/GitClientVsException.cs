﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitClientVS.Infrastructure
{
    public class GitClientVsException : Exception
    {
        public GitClientVsException(string message) : base(message) { }
    }
}
