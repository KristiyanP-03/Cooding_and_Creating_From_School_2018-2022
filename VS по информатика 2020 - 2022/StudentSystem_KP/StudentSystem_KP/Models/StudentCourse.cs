using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem_KP.Models
{
    class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Students { get; set; }
        public Course Courses { get; set; }
    }
}
