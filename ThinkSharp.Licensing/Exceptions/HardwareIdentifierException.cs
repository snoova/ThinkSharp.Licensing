using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkSharp.Licensing.Exceptions
{
    public class HardwareIdentifierException : Exception
    {
        public HardwareIdentifierException(string message)
           : base(message)
        { }
    }
}
