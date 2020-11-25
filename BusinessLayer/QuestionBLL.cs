using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class QuestionBLL : IBusiness<Question>
    {
        UnitOfWork _uow;
        public QuestionBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(Question item)
        {
            throw new NotImplementedException();
        }

        public Question Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Question item)
        {
            throw new NotImplementedException();
        }

        public bool Update(Question item)
        {
            throw new NotImplementedException();
        }
    }
}
