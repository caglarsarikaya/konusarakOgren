using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Exam
    {
        public Exam()
        {
            Questions = new HashSet<Question>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Head { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
