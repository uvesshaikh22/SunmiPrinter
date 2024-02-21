using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class Barcode
    {
        public string Content { get; set; }
        public int HRIPosition { get; set; }
        public BarcodeModel Model { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool CutPaper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content">QR Value</param>
        /// <param name="hRIPosition">1=Above QRCode,2=Below QRCode,3=Above and Below</param>
        /// <param name="model"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="cutPaper"></param>
        public Barcode(string content, BarcodeModel model, int hRIPosition = 1, int width = 6, int height = 150, bool cutPaper = true)
        {
            Content = content;
            HRIPosition = hRIPosition;
            Model = model;
            Width = width;
            Height = height;
            CutPaper = cutPaper;
        }
        /// <summary>
        /// Initializes a new instance of the Barcode class with specified parameters.
        /// </summary>
        /// <param name="content">The content (data) of the barcode.</param>
        /// <param name="hRIPosition">The position of the human-readable interpretation (HRI) in the barcode. Default is 1.</param>
        /// <param name="width">The width of the barcode. Default is 6.</param>
        /// <param name="height">The height of the barcode. Default is 150.</param>
        /// <param name="cutPaper">A flag indicating whether to cut paper after printing the barcode. Default is true.</param>
        public Barcode(string content, int hRIPosition = 1, int width = 6, int height = 150, bool cutPaper = true)
        {
            Content = content;
            HRIPosition = hRIPosition;
            Model = new BarcodeModel(0, "test", BarcodeFormat.UpcA);
            Width = width;
            Height = height;
            CutPaper = cutPaper;
        }

        public bool IsValid()
        {
            if (Model == null || Content == null) return false;
            return Model.IsValid(Content);
        }

        public override string ToString()
        {
            return $"Barcode[Content={Content}, HRIPosition={HRIPosition}, Model={Model.Name}, Width={Width}, Height={Height}, CutPaper={CutPaper}]";
        }
    }
}
