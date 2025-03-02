using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1.Models
{
    // Data Annotation Mapping:
    [PrimaryKey("Ins_Id", "Course_Id")]
    public class Course_Ins
    {
        public int Ins_Id { get; set; }
        public int Course_Id { get; set; }
        [Required]
        public string Evaluate { get; set; }
    }
}
