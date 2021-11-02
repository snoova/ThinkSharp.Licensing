using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkSharp.Licensing.Exceptions
{
    public class LicenseExpiredException : Exception
    {
        public DateTime ExpirationDateTime { get; }

        public LicenseExpiredException(string message)
           : base(message)
        { }

        public LicenseExpiredException(string message, DateTime expirationDateTime) : this(message)
        {
            ExpirationDateTime = expirationDateTime;
        }
    }
}
