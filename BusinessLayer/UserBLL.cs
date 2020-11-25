using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBLL : IBusiness<User>
    {
        UnitOfWork _uow;
        public UserBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(User item)
        {
            _uow.User.Add(item);
            return _uow.ApplyChanges();
        }

        public User Get(int id)
        {
            return _uow.User.Get(id);
        }

        public List<Exam> GetExam()
        {
            return _uow.Exam.GetAll();
        }

        public List<User> GetAll()
        {
            return _uow.User.GetAll();
        }

        public bool Remove(User item)
        {
            throw new NotImplementedException();
        }

        public bool Update(User item)
        {
            throw new NotImplementedException();
        }

        public User LoginUser(string username, string password)
        {
            return GetAll().Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
        }

    }
}
