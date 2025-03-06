using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Models
{
    // Mapping By Convention
    public class Course
    {
        public int CourseId { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        [InverseProperty("Course")]
        public ICollection<Stud_Course> Stud_Courses { get; set; }

        
        // Course -(M)- Belongs to -(1)- Topic =>
        public int Top_Id { get; set; }
        public Topic Topic { get; set; }


        // Instructor -(M)- Gives -(M)- Course =>
        [InverseProperty("Course")]
        public ICollection<Course_Ins> Course_Ins { get; set; }
    }
}
