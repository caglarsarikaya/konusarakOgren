using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork
    {
        KonusarakOgrenContext _context;
        public UnitOfWork()
        {
            _context = new KonusarakOgrenContext();
        }

        Repository<User> _user;
        public Repository<User> User
        {
            get
            {
                if (_user == null)
                {
                    _user = new Repository<User>(_context);
                }
                return _user;
            }
        }

        Repository<Exam> _exam;
        public Repository<Exam> Exam
        {
            get
            {
                if (_exam == null)
                {
                    _exam = new Repository<Exam>(_context);
                }
                return _exam;
            }
        }

        Repository<Question> _question;
        public Repository<Question> Question
        {
            get
            {
                if (_question == null)
                {
                    _question = new Repository<Question>(_context);
                }
                return _question;
            }
        }

        Repository<Answer> _answer;
        public Repository<Answer> Answer
        {
            get
            {
                if (_answer == null)
                {
                    _answer = new Repository<Answer>(_context);
                }
                return _answer;
            }
        }



        DbContextTransaction _tran;
        public bool ApplyChanges()
        {
            bool isSuccess = false;
            _tran = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                _context.SaveChanges();
                _tran.Commit();
                isSuccess = true;
            }
            catch (Exception e)
            {
                _tran.Rollback();
                isSuccess = false;

                throw new Exception(e.Message);
            }
            finally
            {
                _tran.Dispose();
            }
            return isSuccess;
        }
    }
}
