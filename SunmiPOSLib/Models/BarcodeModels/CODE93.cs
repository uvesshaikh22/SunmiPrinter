using System;
using System.Collections.Generic;
using System.Text;
using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class CODE93 : BarcodeModel
    {
        public CODE93() : base(7, "CODE93", BarcodeFormat.Code93)
        {
        }
    }
}
