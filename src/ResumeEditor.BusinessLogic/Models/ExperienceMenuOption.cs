using ResumeEditor.BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.BusinessLogic.Models
{
    public class ExperienceMenuOption
    {
        public string OptionKey { get; set; }
        public Guid ExperienceId { get; set; }
        public RecordOperation Operation { get; set; }
    }
}
