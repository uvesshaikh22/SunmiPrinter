using System;
using System.Collections.Generic;
using System.Text;
using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class EAN13 : NumericalOnlyBarcodeModel
    {
        public EAN13() : base(2, "EAN13", BarcodeFormat.Ean13)
        {
        }

        public override bool IsValid(string content)
        {
            return base.IsValid(content) && content.Length == 13;
        }
    }
}
