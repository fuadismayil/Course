using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem.Models
{
    public class Subject: BaseEntity
    {
        public string SubjectName { get; set; }
        public int SubjectHours { get; set; }
    }
}
