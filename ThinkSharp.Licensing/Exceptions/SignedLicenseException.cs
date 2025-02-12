﻿// Copyright (c) Jan-Niklas Schäfer. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

using System;
using System.Linq;

namespace ThinkSharp.Licensing.Exceptions
{
    public class SignedLicenseException : Exception
    {
        public SignedLicenseException(string message)
            : base(message)
        { }
    }
}
