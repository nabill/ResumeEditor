using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.BusinessLogic.Models
{
    public class Study
    {
        public Study()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Diploma { get; set; }
        public string year { get; set; }
        public string School { get; set; }
    }
}
