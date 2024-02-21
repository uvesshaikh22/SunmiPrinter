

using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class CODE128B : BarcodeModel
    {
        public CODE128B() : base(9, "CODE128B", BarcodeFormat.Code128)
        {
        }
    }
}
