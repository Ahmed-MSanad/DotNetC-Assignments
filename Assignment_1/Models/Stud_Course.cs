using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Models
{ // Mapping using Fluent API
    public class Stud_Course
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        [Range(0, 100)]
        public double Grade { get; set; }
    }
}
