using System.Text.RegularExpressions;
using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public abstract class NumericalOnlyBarcodeModel : BarcodeModel
    {
        public NumericalOnlyBarcodeModel(int id, string name, BarcodeFormat format) : base(id, name, format)
        {
        }

        public override bool IsValid(string content)
        {
            if (!base.IsValid(content)) return false;
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(content);
        }
    }
}
