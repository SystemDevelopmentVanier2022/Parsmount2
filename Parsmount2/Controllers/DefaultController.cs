using Parsmount2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parsmount2.Controllers
{
    public class DefaultController : Controller
    {
        test1Entities db = new test1Entities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DisplayProduct()
        {
            List < t1 > list = db.t1.OrderByDescending(x => x.c1).ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(t1 pro)
        {
            db.t1.Add(pro);
            db.SaveChanges();
            return RedirectToAction("DisplayProduct");
        }


    }
}