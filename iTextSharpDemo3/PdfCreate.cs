using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace iTextSharpDemo3
{
    public class PdfCreate
    {
        BaseFont BF_Light = BaseFont.CreateFont(@"C:\Windows\Fonts\simsun.ttc,0", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

        public PdfCreate()
        {

        }

        public void AddText()
        {
            //要设置字体和大小
            //Paragraph p = new Paragraph(fields[i], new Font(BF_Light, 13));
            int rowNum = 0;
            int mainColumn = 1;
            int i = 0 ;
            Paragraph p = new Paragraph("fields[i]", new Font(BF_Light, 13));

            PdfPCell cell = new PdfPCell(p);
            PdfPTable table = new PdfPTable(1);
            //设置cell属性
            //cell.Border = Rectangle.NO_BORDER;
            if (rowNum == 0)
            {
                cell.BackgroundColor = BaseColor.GRAY;
            }
            if (i == mainColumn - 1)
            {
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            }
            //添加单元格
            table.AddCell(cell);
        }
    }
}
