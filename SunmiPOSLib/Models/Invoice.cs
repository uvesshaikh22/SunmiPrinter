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
}
