using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkSharp.Licensing.Exceptions
{
    public class ProductMismatchException : Exception
    {
        public string ApplicationCode { get; }

        public ProductMismatchException(string message)
           : base(message)
        { }

        public ProductMismatchException(string message, string applicationCode) : this(message)
        {
            ApplicationCode = applicationCode;
        }
    }
}
