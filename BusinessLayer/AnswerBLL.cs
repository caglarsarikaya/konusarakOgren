using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AnswerBLL : IBusiness<Answer>
    {
        UnitOfWork _uow;
        public AnswerBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(Answer item)
        {
            throw new NotImplementedException();
        }

        public Answer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Answer> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Answer item)
        {
            throw new NotImplementedException();
        }

        public bool Update(Answer item)
        {
            throw new NotImplementedException();
        }
    }
}
