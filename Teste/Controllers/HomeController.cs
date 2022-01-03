using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }        
        public ActionResult UpDate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpDate()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }        
        [HttpPost]
        public ActionResult Delete()
        {
            return View();
        }
    }
}