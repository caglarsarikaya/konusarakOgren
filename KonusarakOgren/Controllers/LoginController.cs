using Entities;
using KonusarakOgren.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KonusarakOgren.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if ((Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null) || Session["User"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user, string Remember)
        {
            bool result = new LoginHelper().LoginUser(user.UserName, user.Password, System.Web.HttpContext.Current);
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //TempData["Error"] = "KullanıcıAdı ve Şifre kombinasyonları uyuşmuyor";
                
                return Content("<script language='javascript' type='text/javascript'>alert('KullanıcıAdı ve Şifre Kombinasyonu HATALI !!!');window.location = '/Login/Index';</script>");
            }
        }
        
    }
}