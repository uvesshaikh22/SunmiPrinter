using System;
using System.Collections.Generic;
using System.Text;
using ZXing;

namespace SunmiPOSLib.Models
{
    public class CODE93 : BarcodeModel
    {
        public CODE93() : base(7, "CODE93", BarcodeFormat.CODE_93)
        {
        }
    }
}
