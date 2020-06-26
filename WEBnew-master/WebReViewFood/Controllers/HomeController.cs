using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebReviewFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NgoaiThanh()
        {
            return View();
        }
        public ActionResult KhachSan()
        {
            return View();
        }
        public ActionResult Resort()
        {
            return View();
        }
        public ActionResult LienHe()
        {
            return View();
        }
        public ActionResult HomeStay()
        {
            return View();
        }
        public ActionResult NoiThanh()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}