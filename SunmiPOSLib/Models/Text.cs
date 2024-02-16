using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Models
{
    public class Text
    {
        private string[] encodeStrings = { "IBM437", "ibm850", "IBM860", "IBM863", "IBM865", "ibm857", "ibm737", "Windows-1252", "cp866", "ibm852", "IBM00858", "windows-874", "IBM855", "DOS-862", "IBM864", "GB18030", "big5", "ks_c_5601-1987", "utf-8", "utf-16", "utf-32", "unicodeFFFE" };
        public string Content { get; set; }
        public bool IsBold { get; set; }
        public bool IsUnderline { get; set; }
        public string CharsetOption { get; set; }
        public int TextSize { get; set; }
        public int Record { get; set; }
        public string Encoding { get; set; }
        /// <summary>
        /// Initializes a new instance of the Text class with specified parameters.
        /// </summary>
        /// <param name="content">The text content.</param>
        /// <param name="isBold">A boolean indicating whether the text is bold.</param>
        /// <param name="isUnderline">A boolean indicating whether the text is underlined.</param>
        /// <param name="charsetOption">The character set option for the text.</param>
        /// <param name="textSize">The size of the text.</param>
        /// <param name="record">The record identifier for the text.</param>
        public Text(string content, bool isBold, bool isUnderline, string charsetOption, int textSize, int record)
        {
            Content = content;
            IsBold = isBold;
            IsUnderline = isUnderline;
            CharsetOption = charsetOption;
            TextSize = textSize;
            Record = record;
            Encoding = encodeStrings[record];
        }
        /// <summary>
        /// Initializes a new instance of the Text class with specified parameters.
        /// </summary>
        /// <param name="content">The text content.</param>
        /// <param name="isBold">A boolean indicating whether the text is bold. Default is false.</param>
        /// <param name="isUnderline">A boolean indicating whether the text is underlined. Default is false.</param>
        /// <param name="textSize">The size of the text. Default is 24.</param>
        public Text(string content, bool isBold = false, bool isUnderline = false, int textSize = 24)
        {
            Content = content;
            IsBold = isBold;
            IsUnderline = isUnderline;
            TextSize = textSize;
            CharsetOption = "utf-32";
            Record = 21;
            Encoding = encodeStrings[20];
        }
    }
}
