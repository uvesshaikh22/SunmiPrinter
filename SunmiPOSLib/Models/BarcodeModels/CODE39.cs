﻿using System.Text.RegularExpressions;
using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class CODE39 : BarcodeModel
    {
        public CODE39() : base(4, "CODE39", BarcodeFormat.Code39)
        {
        }

        public override bool IsValid(string content)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9 \-\.\$\/\+\%]{1,43}$");
            return base.IsValid(content) && regex.IsMatch(content);
        }
    }
}
