using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_1.Configurations
{
    public class TopicConfigurations : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(x => x.TopId);

            builder.Property(x => x.TopId)
                   .UseIdentityColumn(1, 1);


            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // Course -(M)- Belongs to -(1)- Topic =>
            builder.HasMany(x => x.Courses)
                   .WithOne(x => x.Topic)
                   .HasForeignKey(x => x.Top_Id);
        }
    }
}
