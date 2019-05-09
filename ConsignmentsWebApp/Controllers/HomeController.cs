using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsignmentsWebApp.Models;

namespace ConsignmentsWebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly ConsingnmentContext db = new ConsingnmentContext();

        public ActionResult Index()
        {
            IEnumerable<Consignment> consignments = db.Consignments;
            ViewBag.Consignments = consignments;
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            Consignment consignment = new Consignment();
            return View(consignment);
        }
        [HttpPost]
        public ActionResult Create(Consignment consignment)
        {
            db.Consignments.Add(consignment);
            db.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var consignment = db.Consignments.Find(id);
            if (consignment == null)
            {
                return HttpNotFound();
            }

            return View(consignment);
        }

        [HttpPost]
        public ActionResult Edit(Consignment consignment)
        {
            Consignment newConsignment = db.Consignments.Find(consignment.Id);
            newConsignment.Name = consignment.Name;
            newConsignment.Leader = consignment.Leader;
            db.Entry(newConsignment).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult More(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            IEnumerable<Consignment> consignments = db.Consignments;
            ViewBag.Consignments = consignments;
            ViewBag.Id = id;
            return View();
        }
    }
}