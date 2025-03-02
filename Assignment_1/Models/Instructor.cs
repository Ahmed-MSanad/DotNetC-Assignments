using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_1.Models
{ // Mapping By Data Annotations :

    [Table("InstructorTable", Schema ="Teaching")]
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int insId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please, Instructor Name Can't exceed 50 characters!! Try Again")]
        [MinLength(5, ErrorMessage = "Please, Instructor Name has to be more than or equal to 5 characters!!")]
        [RegularExpression(@"/^[A-Z]\w{5,}$/", ErrorMessage = "Instructor Name has to begin with Uppercase and at least 6 characters")]
        [Display(Name = "Instructor Name")]
        [ReadOnly(true)]
        public string? Name { get; set; }

        public double Bouns { get; set; }

        [Range(1000, 4000)]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Salary { get; set; }

        [MaxLength(100, ErrorMessage = "Please, Instructor Address has to be less than or equal to 100 characters!!")]
        [MinLength(10, ErrorMessage = "Please, Instructor Address has to be more than or equal to 10 characters!!")]
        [DefaultValue("Unknown Instructor Address")]
        [Column(TypeName = SqlServerTypes.varchar50)]
        public string? Address { get; set; }

        public double HourRate { get; set; }

        public int Dep_Id { get; set; }
    }
}
