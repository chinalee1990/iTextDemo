using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace iTextSharpDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreatePdf();
        }

        //创建PDF
        private void CreatePdf()
        {
            //BaseFont BF_Light = BaseFont.CreateFont(@"C:\Windows\Fonts\simsun.ttc,0", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            //定义一个Document，并设置页面大小为A4，竖向 
            iTextSharp.text.Document doc = new Document(PageSize.A4);
            try
            {
                //写实例 
                PdfWriter.GetInstance(doc, new FileStream("D:\\Hello.pdf", FileMode.Create));
                AddFileInfo();

                doc.Open();
                //载入字体 
                //BaseFont.AddToResourceSearch("iTextAsian.dll");
                //BaseFont.AddToResourceSearch("iTextAsianCmaps.dll");
                ////"UniGB-UCS2-H" "UniGB-UCS2-V"是简体中文，分别表示横向字 和 // 纵向字 //" STSong-Light"是字体名称 
                //BaseFont baseFT = BaseFont.CreateFont(@"c:\windows\fonts\SIMHEI.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
               
                BaseFont baseFT = BaseFont.CreateFont(@"C:\Windows\Fonts\simsun.ttc,0", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFT); //写入一个段落, Paragraph 

                doc.Add(new Paragraph("您好， PDF !", font));
                doc.Add(new Paragraph("您好， PDF !", font));
                
                //关闭document 
                doc.Close();
                //打开PDF，看效果 
                Process.Start("D:\\Hello.pdf");
            }
            catch (DocumentException de) 
            {
                Console.WriteLine(de.Message); 
                //Console.ReadKey();
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message); 
               // Console.ReadKey(); 
            }
        }

        void AddFileInfo()
        {
            //#region 设置PDF的头信息，一些属性设置，在Document.Open 之前完成
            //doc.AddAuthor("作者幻想Zerow");
            //doc.AddCreationDate();
            //doc.AddCreator("创建人幻想Zerow");
            //doc.AddSubject("Dot Net 使用 itextsharp 类库创建PDF文件的例子");
            //doc.AddTitle("此PDF由幻想Zerow创建，嘿嘿");
            //doc.AddKeywords("ASP.NET,PDF,iTextSharp,幻想Zerow");
            ////自定义头 
            //doc.AddHeader("Expires", "0");
            //#endregion //打开document
        }



    }
}
