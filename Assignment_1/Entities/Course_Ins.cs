using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Entities
{
    public class Course_Ins
    {
        [ForeignKey("Ins_Id")]
        [Key, Column(Order = 0)]
        public int Ins_Id { get; set; }
        [ForeignKey("Course_Id")]
        [Key, Column(Order = 1)]
        public int Course_Id { get; set; }
        public string Evaluate { get; set; }
    }
}
