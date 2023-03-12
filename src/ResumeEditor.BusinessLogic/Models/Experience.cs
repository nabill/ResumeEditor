using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.BusinessLogic.Models
{
    public class Experience
    {
        public Experience()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
    }
}
