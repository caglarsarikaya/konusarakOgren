using BusinessLayer;
using Entities;
using KonusarakOgren.Helper;
using KonusarakOgren.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace KonusarakOgren.Controllers
{
    public class HomeController : Controller
    {
        ExamBLL _examBLL = new ExamBLL();
        [LoginRequired]
        public ActionResult Index()
        {
            UserBLL _userBLL = new UserBLL();
            int max = 0;
            string url = "https://www.wired.com/feed/rss";
            XmlTextReader reader = new XmlTextReader(url);
            RssArticle rssArticle = new RssArticle();
            List<RssArticle> model = new List<RssArticle>();
            string Element = "";
            string Text = "";
      
            while (reader.Read())
            {
       
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Element = "<" + reader.Name + ">";
                        break;
                    case XmlNodeType.Text:
                        Text = reader.Value;
                        switch (Element)
                        {
                            case "<title>":
                                rssArticle.Title = Text;
                                break;
                            case "<link>":
                                rssArticle.Link = Text;
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        Element = "</" + reader.Name + ">";
                        if (Element == "</item>")
                        {
                            model.Add(rssArticle);
                            rssArticle = new RssArticle();
                            max++;
                        }
                        break;
                }
                
                if (max == 5)
                {
                    break;
                }
            }

          
            return View(model);
        }
        [HttpPost]
        public JsonResult GetContent(string deger)
        {
            return Json(_examBLL.GetContent(deger), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateInput(false)]
        //[AllowHtml]
        public ActionResult Index(string ExamHead, string ExamContent, SoruCevapModel sCmodel)
        {

            if(string.IsNullOrEmpty(ExamHead) || string.IsNullOrEmpty(ExamContent)) throw new System.ArgumentException("Makale Seçimi Yapınız");

            Exam exam = new Exam();
            exam.Head = ExamHead;
            exam.Description = ExamContent;
            exam.Date = DateTime.Now;
            User user = new User();
            user = (User)Session["User"];

            exam.UserId = user.Id;


            int answerRow = 0;
            int trueRow = 0;
            foreach (var item in sCmodel.Question)
            {
                Question question = new Question();
                question.ExamId = exam.Id;
                question.Content = item;
                int ring = 0;
                for (int i = 0; i < 4; i++)
                {
                    Answer answer = new Answer();
                    answer.QuestionId = question.Id;
                    answer.Text = sCmodel.Answer[answerRow];
                    answer.IsTrue = (answer.Text == sCmodel.True[trueRow]) ? true : false;
                    question.Answers.Add(answer);
                    answerRow += 1;
                }
                ring += 1;
                trueRow += 1;
                if (ring == 4)
                {
                    break;
                }
                exam.Questions.Add(question);
            }
            _examBLL.Add(exam);

            return RedirectToAction("ExamList");
        }
        public ActionResult ExamList()
        {
            List<Exam> examList = _examBLL.GetAll().ToList();
            return View(examList);
        }
        [HttpPost]
        public JsonResult ExamDelete(int id)
        {
            Exam exam = _examBLL.Get(id);
            _examBLL.Remove(exam);

            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ExamTest(int id)
        {
            Exam exam = new Exam();
            exam = _examBLL.Get(id);

            return View(exam);
        }
        [HttpPost]
        public JsonResult ExamEnd(string[] cevaplar)
        {
            return Json(_examBLL.ExamEnd(cevaplar), JsonRequestBehavior.AllowGet);
        }
    }
}