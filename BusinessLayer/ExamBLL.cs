using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ExamBLL : IBusiness<Exam>
    {
        UnitOfWork _uow;
        public ExamBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(Exam item)
        {
            _uow.Exam.Add(item);
            return _uow.ApplyChanges();
        }

        public Exam Get(int id)
        {
            return _uow.Exam.Get(id);
        }
        public Answer GetAnswer(int id)
        {
            return _uow.Answer.Get(id);
        }
        public Question GetQuestion(int id)
        {
            return _uow.Question.Get(id);
        }

        public List<Exam> GetAll()
        {
            return _uow.Exam.GetAll();
        }

        public bool Remove(Exam item)
        {
            _uow.Exam.Remove(item);
            return _uow.ApplyChanges();
        }
        

        public bool Update(Exam item)
        {
            _uow.Exam.Update(item);
            return _uow.ApplyChanges();
        }

        public string GetContent(string deger)
        {
            WebRequest req = HttpWebRequest.Create(deger);
            WebResponse res;
            res = req.GetResponse();
            StreamReader data = new StreamReader(res.GetResponseStream(), System.Text.Encoding.UTF8);

            string icerik = data.ReadToEnd();
            int start = icerik.IndexOf("<article class=");
            int end = icerik.IndexOf("</article>");
            string Article = icerik.Substring(start, end - start);

            return (Article);
            
        }

        public List<bool> ExamEnd(string[] cevaplar)
        {
            List<bool> sonuclar = new List<bool>();
            foreach (var item in cevaplar)
            {
                Answer answer = GetAnswer(int.Parse(item));
                bool sonuc = (answer.IsTrue == true) ? true : false;
                sonuclar.Add(sonuc);
            }
            return sonuclar;
        }
    }
}
