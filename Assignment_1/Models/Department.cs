using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_1.Models
{ // Mapping By Data Annotations:
    public class Department
    {
        [Key]
        public int deptId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Please, Department Name has to be less than or equal to 50 characters!!")]
        [MinLength(5, ErrorMessage = "Please, Department Name has to be more than or equal to 5 characters!!")]
        public string? Name { get; set; }
        public DateOnly HiringDate { get; set; }

        [InverseProperty("Department")]
        public ICollection<Student> Students { get; set; }


        // Department -(1)- has -(M)- instructor =>
        [InverseProperty("Department")]
        public ICollection<Instructor> Instructors { get; set; }


        // instructor -(1)- manage -(M)- Department =>
        [ForeignKey("Instructor")]
        public int? Ins_Id { get; set; }
        public Instructor Instructor { get; set; }

    }
}

