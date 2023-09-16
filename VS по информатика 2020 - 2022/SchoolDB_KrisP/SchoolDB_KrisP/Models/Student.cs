using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB_KrisP.Models
{
    class Student
    { 
    [Key]
    public int Id { get; set; }
    [Required, MaxLength(30)]
    public string Name { get; set; }
    [ForeignKey(nameof(Student))]
    public int AddressId { get; set; }
    public Adress Adresses { get; set; }
    }
}
