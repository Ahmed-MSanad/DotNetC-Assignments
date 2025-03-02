using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_1.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Try Adding Some Configurations
            builder.ToTable("StudentTable");

            builder.HasKey(x => x.StuId);

            builder.Property(x => x.StuId)
                   .UseIdentityColumn(1, 1); // Which is the default :)

            
            builder.Property("FName")
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType(SqlServerTypes.varchar100); // is safe more than writing it many times


            builder.Property(nameof(Student.Address))
                   .HasDefaultValue("unKnown")
                   .HasColumnName("Student_Address")
                   .HasColumnType(SqlServerTypes.varchar50); // is safe more than writing it many times
        }
    }
}
