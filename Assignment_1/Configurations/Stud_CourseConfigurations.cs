using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_1.Configurations
{
    public class Stud_CourseConfigurations : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.HasKey(x => new { x.Stud_Id, x.Course_Id });

            builder.HasOne(x => x.Course)
                   .WithMany(x => x.Stud_Courses)
                   .HasForeignKey(x => x.Course_Id);

            builder.HasOne(x => x.Student)
                   .WithMany(x => x.Stud_Courses)
                   .HasForeignKey(x => x.Stud_Id);
        }
    }
}
