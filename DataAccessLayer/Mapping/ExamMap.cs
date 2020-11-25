using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class ExamMap : EntityTypeConfiguration<Exam>
    {
        public ExamMap()
        {
            HasKey(x => x.Id);

            HasRequired(x => x.User).WithMany(x => x.Exams).HasForeignKey(x => x.UserId).WillCascadeOnDelete(true);

            Property(x => x.Head)
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .IsRequired();

            Property(x => x.Description)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            Property(x => x.Date)
                .HasColumnType("datetime")
                .IsRequired();


        }
    }
}
