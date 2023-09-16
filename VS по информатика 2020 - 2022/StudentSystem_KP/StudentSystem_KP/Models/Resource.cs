using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem_KP.Models
{
    class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        public int CourseId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public ResourceClass ResourceType { get; set; }
        [MaxLength(2048)]
        public string Url { get; set; }
    }
}
