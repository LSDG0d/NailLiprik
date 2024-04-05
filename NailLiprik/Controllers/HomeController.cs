using NailLiprik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NailLiprik.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Информация о нас.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Наши контакты.";

            return View();
        }
        public ActionResult Resume()
        {
            ViewBag.Message = "Примерны наших работ";
            return View();
        }
        public ActionResult Review()
        {
            List<ReviewsModels> reviews = new List<ReviewsModels>();

            return View(reviews);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}