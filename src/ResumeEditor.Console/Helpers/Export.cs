using ResumeEditor.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.Console.Helpers
{
    public class Export
    {   
        public void GeneratePDF()
        {
            ReportService reportService = new ReportService();
            string res = reportService.ExportPdf(Objects.resume);
            
            
            
            
            
            res = res;
        }
    }
}
