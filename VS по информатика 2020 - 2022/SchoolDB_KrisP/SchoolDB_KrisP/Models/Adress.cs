using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB_KrisP.Models
{
    class Adress
    {
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Text { get; set; }
        [ForeignKey(nameof(Adress))]
        public int StudentId { get; set; }
        public Student Students { get; set; }
    }
}
