using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeEditor.BusinessLogic.Models
{
    public class Resume
    {
        public Resume()
        {
            Experiences = new();
            Studies = new();
            Languages = new();
        }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Study> Studies { get; set; }
        public List<Language> Languages { get; set; }
    }
}
