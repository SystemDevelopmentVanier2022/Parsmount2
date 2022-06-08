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
            List<t1> list = db.t1.OrderByDescending(x => x.c1).ToList();
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




        [HttpGet]
        public ActionResult DisplayProduct2()
        {
            List<t3> list = db.t3.OrderByDescending(x => x.cc1).ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult CreateProduct2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct2(t3 pro)
        {
            db.t3.Add(pro);
            db.SaveChanges();
            return RedirectToAction("DisplayProduct2");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            t1 pr = db.t1.Where(x => x.c1 == id).SingleOrDefault();
            return View(pr);
        }

        [HttpPost]
        public ActionResult UpdateProduct(int id, t1 pro)
        {
            t1 pr = db.t1.Where(x => x.c1 == id).SingleOrDefault();
            pr.c2 = pro.c2;
            pr.c3 = pro.c3;
            db.SaveChanges();
            return RedirectToAction("DisplayProduct");
        }
    }    
}