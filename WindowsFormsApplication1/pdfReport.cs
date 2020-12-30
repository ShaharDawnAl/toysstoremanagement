using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507

namespace WindowsFormsApplication1
{
    public class pdfReport //class for creating pdf file
    {
        private Document doc;
        private Font myFont;


        public pdfReport()
        {
            doc = new Document();
            //create pdf file
            PdfWriter.GetInstance(doc, new FileStream("customersPdf.pdf", FileMode.Create));
            //open pdf file
            doc.Open();
             
        }
        public pdfReport(string fileName)
        {
            doc = new Document();
            //create pdf file
            PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
            //open pdf file
            doc.Open();
        }

        public void SetTitle(string title) //add title to file
        {
            Font myFont = new Font(Font.FontFamily.COURIER, 18, Font.ITALIC);
            myFont.Color = BaseColor.BLUE;
            Paragraph para=new Paragraph(title, myFont);
            para.Alignment=Element.ALIGN_CENTER;
            doc.Add(para);
           
        }
        public void SetImage(string imagePath) //add image to file
        {
            iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(imagePath);
            pic.ScaleToFit(540f, 420f);
            pic.SpacingBefore = 10f;
            pic.SpacingAfter = 1f;
            pic.Alignment = iTextSharp.text.Image.ALIGN_CENTER;

            
            pic.Border = iTextSharp.text.Rectangle.BOX;
            pic.BorderColor = iTextSharp.text.BaseColor.BLACK;
            pic.BorderWidth = 3f;
            doc.Add(pic);
        }

        public void SetCounter(string count) //add counter to file
        {
            Font myFont = new Font(Font.FontFamily.COURIER, 18, Font.ITALIC);
            myFont.Color = BaseColor.BLUE;
            Paragraph para = new Paragraph("There are currently "+count+" Customers", myFont);
            para.Alignment = Element.ALIGN_CENTER;
            doc.Add(para);

        }

        public void SetCustomersTable(Customers[] cTable)  //add customers table
        {
          
            PdfPTable myTable = new PdfPTable(5);         
            myTable.SpacingBefore = 20f;

            float[] widthCell = new float[5];
            for (int i = 0; i < 5; i++)
                widthCell[i] = 33;
            
            myTable.SetTotalWidth(widthCell);
            PdfPCell myCell = new PdfPCell();
            myCell.GrayFill = 0.5f;
            myCell.BackgroundColor = BaseColor.WHITE;
            myCell.FixedHeight = 20;
            myCell.BorderColor = BaseColor.DARK_GRAY;
            myCell.HorizontalAlignment = Element.ALIGN_CENTER;
            myCell.VerticalAlignment = Element.ALIGN_CENTER;

            myCell.Phrase = new Phrase("ID");
            myTable.AddCell(myCell);
            myCell.Phrase = new Phrase("Customer ID");
            myTable.AddCell(myCell);
            myCell.Phrase = new Phrase("First Name");
            myTable.AddCell(myCell);
            myCell.Phrase = new Phrase("Last Name");
            myTable.AddCell(myCell);
            myCell.Phrase = new Phrase("Customer City");
            myTable.AddCell(myCell);

            for (int i = 0; i < cTable.Length; i++)
            {
                myCell.Phrase = new Phrase(cTable[i].Id.ToString());
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(cTable[i].Ide.ToString());
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(cTable[i].FName.ToString());
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(cTable[i].LName.ToString());
                myTable.AddCell(myCell);
                myCell.Phrase = new Phrase(cTable[i].City.ToString());
                myTable.AddCell(myCell);
            }
            doc.Add(myTable);
            
        }


        public void CloseReport() //close file
        {
            if (doc.IsOpen()==true)
                doc.Close();

        }
        ~pdfReport() 
        {
            if (doc.IsOpen() == true) 
                doc.Close();
        }

    }
}
