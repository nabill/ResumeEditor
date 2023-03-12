using ResumeEditor.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace ResumeEditor.BusinessLogic.Services
{
    public class ReportService
    {
        public string ExportPdf(Resume resume)
        {

            string pdfpath = "Resume_"+DateTime.Now.ToString("yyyyMMddhhmmss")+".pdf";
            Document doc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfpath, FileMode.Create));
            try
            {
                doc.Open();
                
                PdfPTable PdfTable;
                PdfPCell PdfCell;
                PdfContentByte pcb;
                BaseFont FontHelveticaBold = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false);
                BaseFont FontHelvetica = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                BaseFont FontTimesItalic = BaseFont.CreateFont(BaseFont.TIMES_ITALIC, BaseFont.CP1252, false);
                int RowPos = 790;

                
                pcb = writer.DirectContent;
                pcb.BeginText();
                pcb.SetFontAndSize(FontHelveticaBold, 17);
                pcb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, resume.Fullname, 30, RowPos, 0);
                pcb.EndText();
                
                RowPos = RowPos - 20;
                pcb = writer.DirectContent;
                pcb.BeginText();
                pcb.SetFontAndSize(FontHelvetica, 11);
                pcb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, $"Adress : {resume.Address}", 30, RowPos, 0);
                pcb.EndText();

                RowPos = RowPos - 20;
                pcb = writer.DirectContent;
                pcb.BeginText();
                pcb.SetFontAndSize(FontHelvetica, 11);
                pcb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, $"Phone : {resume.Phone}", 30, RowPos, 0);
                pcb.EndText();

                RowPos = RowPos - 20;
                pcb = writer.DirectContent;
                pcb.BeginText();
                pcb.SetFontAndSize(FontHelvetica, 11);
                pcb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, $"Email : {resume.Email}", 30, RowPos, 0);
                pcb.EndText();


                RowPos = RowPos - 50;

                pcb = writer.DirectContent;
                pcb.BeginText();
                pcb.SetFontAndSize(FontHelveticaBold, 17);
                pcb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "EXPERIENCE", 30, RowPos, 0);
                pcb.EndText();

                foreach (var experience in resume.Experiences)
                {
                    RowPos = RowPos - 30;
                    pcb = writer.DirectContent;
                    pcb.BeginText();
                    pcb.SetFontAndSize(FontHelveticaBold, 11);
                    pcb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, $"* {experience.Company} ({experience.Start}-{experience.End})", 30, RowPos, 0);
                    pcb.EndText();

                    RowPos = RowPos - 20;
                    pcb = writer.DirectContent;
                    pcb.BeginText();
                    pcb.SetFontAndSize(FontHelvetica, 11);
                    pcb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, experience.Title, 30, RowPos, 0);
                    pcb.EndText();
                }
                
                
                writer.Flush();
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

            finally
            {
                doc.Close();
            }

            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = @pdfpath,
                UseShellExecute = true
            });
            return "";
        }
    }
}
