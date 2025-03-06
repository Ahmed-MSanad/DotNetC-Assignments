using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Models
{
    // By Fluent API:
    public class Topic
    {
        public int TopId { get; set; }
        public string Name { get; set; }

        
        // Course -(M)- Belongs to -(1)- Topic =>
        [InverseProperty("Topic")]
        public ICollection<Course> Courses { get; set; }
    }
}
