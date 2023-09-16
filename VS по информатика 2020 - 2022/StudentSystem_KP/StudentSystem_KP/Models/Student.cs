using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem_KP.Models
{
    class Student
    {
        public int StudentId { get; set; }
        public DateTime Birthday { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public int PhoneNumber { get; set; }
        public DateTime? RegisterOn { get; set; }
        public Course Courses { get; set; }
    }
}
