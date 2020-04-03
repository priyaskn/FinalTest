using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    public class EnrollmentPoco
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public virtual CourcePoco Course { get; set; }
        public virtual StudentPoco Student { get; set; }
    }
}
