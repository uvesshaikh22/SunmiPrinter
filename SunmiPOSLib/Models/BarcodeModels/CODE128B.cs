using ZXing;

namespace SunmiPOSLib.Models
{
    public class CODE128B : BarcodeModel
    {
        public CODE128B() : base(9, "CODE128B", BarcodeFormat.CODE_128)
        {
        }
    }
}
