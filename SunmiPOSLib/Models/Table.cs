using System;
using System.Collections.Generic;
using System.Text;
using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    //in String[] colsTextArr, in int[] colsWidthArr, in int[] colsAlign
    public class Table
    {
        public string[] ColumnsText;
        public int[] ColumnsWidth;
        public AlignmentEnum[] ColumnsAlign;

        public Table(string[] columnsText, int[] columnsWidth, AlignmentEnum[] columnsalign)
        {
            ColumnsAlign = columnsalign;
            ColumnsText = columnsText;
            ColumnsWidth = columnsWidth;
        }

        public int[] GetAlignmentsAsInteger()
        {
            List<int> alignments = new List<int>();
            foreach(var alignment in ColumnsAlign)
            {
                alignments.Add((int)alignment);
            }
            return alignments.ToArray();
        }
    }
}
