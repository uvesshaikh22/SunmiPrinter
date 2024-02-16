using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class QRcode
    {
        public string Content { get; set; }
        public int ImpQuant { get; set; }
        public int ImpSize { get; set; }
        public QRCodeCorretionEnum Correction { get; set; }
        public AlignmentEnum Alignment { get; set; }
        public bool CutPaper { get; set; }
        /// <summary>
        /// Initializes a new instance of the QRcode class with specified parameters.
        /// </summary>
        /// <param name="content">The content (data) of the QR code.</param>
        /// <param name="impsize">The size of the QR code's modules (pixels). </param>
        /// <param name="correction">The error correction level for the QR code.</param>
        /// <param name="alignment">The alignment pattern for the QR code.</param>
        /// <param name="cutPaper">A flag indicating whether to cut paper after printing the QR code.</param>
        public QRcode(string content, int impsize, QRCodeCorretionEnum correction, AlignmentEnum alignment, bool cutPaper)
        {
            Content = content;
            ImpQuant = 0;
            ImpSize = impsize;
            Correction = correction;
            Alignment = alignment;
            CutPaper = cutPaper;
        }
        /// <summary>
        /// Initializes a new instance of the QRcode class with specified parameters.
        /// </summary>
        /// <param name="content">The content (data) of the QR code.</param>
        /// <param name="impsize">The size of the QR code's modules (pixels). </param>
        /// <param name="correction">The error correction level for the QR code.</param>
        /// <param name="alignment">The alignment pattern for the QR code.</param>
        public QRcode(string content, int impsize, QRCodeCorretionEnum correction, AlignmentEnum alignment)
        {
            Content = content;
            Alignment = alignment;
            ImpSize = impsize;
            ImpQuant = 0;
            Correction = correction;
            CutPaper = false;
        }
        /// <summary>
        /// Initializes a new instance of the QRcode class with specified parameters.
        /// </summary>
        /// <param name="content">The content (data) of the QR code.</param>
        /// <param name="impsize">The size of the QR code's modules (pixels). Default is 10.</param>
        /// <param name="alignment">The alignment pattern for the QR code. Default is CENTER.</param>
        public QRcode(string content, int impsize = 10, AlignmentEnum alignment = AlignmentEnum.CENTER)
        {
            Content = content;
            ImpQuant = 0;
            ImpSize = impsize;
            Alignment = alignment;
            Correction = QRCodeCorretionEnum.CORRECTION_M;
            CutPaper = false;
        }
        public bool IsValid()
        {
            if (Content == null) return false;
            return true;
        }

        public override string ToString()
        {
            return $"Qrcode[Content={Content}, Imp. Quantity={ImpQuant}, Imp. Size={ImpSize}, Correction Level={Correction}, Alignment={Alignment}, CutPaper={CutPaper}]";
        }

    }
}
