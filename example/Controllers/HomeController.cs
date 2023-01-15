using example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tarihimiz()
        {
            return View();
        }


        public ActionResult Yemeklerimiz()
        {

            return View();
        }

        public ActionResult Foto()
        {


            return View();
        }


        public ActionResult Hakkında()
        {
            return View();
        }



    }
}