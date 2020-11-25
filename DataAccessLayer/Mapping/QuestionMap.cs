using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class QuestionMap : EntityTypeConfiguration<Question>
    {
        public QuestionMap()
        {
            HasKey(x => x.Id);

            HasRequired(x => x.Exam).WithMany(x => x.Questions).HasForeignKey(x => x.ExamId).WillCascadeOnDelete(true);

            Property(x => x.Content)
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .IsRequired();


        }
    }
}
