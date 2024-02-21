

using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class CODE128C : BarcodeModel
    {
        public CODE128C() : base(10,"CODE128C", BarcodeFormat.Code128)
        {
        }
    }
}
