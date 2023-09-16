using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem_KP.Models
{
    class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? Description { get; set; }
        public DateTime EndDate { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
