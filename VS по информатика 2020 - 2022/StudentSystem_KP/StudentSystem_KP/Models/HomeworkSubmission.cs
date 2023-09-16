using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem_KP.Models
{
    class HomeworkSubmission
    {
        public int HomeworkId { get; set; }
        [Column(TypeName = " "), MaxLength(225)]
        public string Content { get; set; }
        public ContentClass ContentType { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public DateTime SubmissionTime { get; set; }
    }
}
