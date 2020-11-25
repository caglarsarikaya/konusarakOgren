using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class AnswerMap : EntityTypeConfiguration<Answer>
    {
        public AnswerMap()
        {
            HasKey(x => x.Id);

            HasRequired(x => x.Question).WithMany(x => x.Answers).HasForeignKey(x => x.QuestionId).WillCascadeOnDelete(true);

            Property(x => x.Text)
                .HasColumnType("nvarchar")
                .HasMaxLength(300)
                .IsRequired();

            Property(x => x.IsTrue)
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
