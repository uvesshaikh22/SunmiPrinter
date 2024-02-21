using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Models
{
    public class Invoice
    {
        public List<string> Content { get; set; }

        public Invoice(List<string> content)
        {
            Content = content;
        }
    }

    public class InvoiceWithQR
    {
        public string Content { get; set; }
        public string QRCode { get; set; }
        public InvoiceWithQR()
        {
            Content = string.Empty;
            QRCode = string.Empty;
        }
    }

}
