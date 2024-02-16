using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Exceptions
{
    public class PrintImageException : Exception
    {
        public PrintImageException() : base("Image printing error.") { } 
    }
}
