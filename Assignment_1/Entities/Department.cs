using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly HiringDate { get; set; }
        [ForeignKey("Ins_Id")]
        public int Ins_Id { get; set; }
    }
}
