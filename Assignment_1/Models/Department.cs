using System.ComponentModel.DataAnnotations;

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
        public int Ins_Id { get; set; }
    }
}

