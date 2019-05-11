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
        //Done
        [HttpGet]
        public ActionResult Create()
        {
            Consignment consignment = new Consignment();
            ViewBag.Locations = db.Locations.ToList();
            return View(consignment);
        }
        [HttpPost]
        public ActionResult Create(Consignment consignment, int[] selectedLocations)
        {
            consignment.Locations.Clear();
            if (selectedLocations != null)
            {
                foreach (var l in db.Locations.Where(lo => selectedLocations.Contains(lo.Id)))
                {
                    consignment.Locations.Add(l);
                }
            }
            db.Entry(consignment).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Done
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var consignment = db.Consignments.Find(id);
            if (consignment == null)
            {
                return HttpNotFound();
            }

            ViewBag.Locations = db.Locations.ToList();
            return View(consignment);
        }
        [HttpPost]
        public ActionResult Edit(Consignment consignment, int[] selectedLocations)
        {
            Consignment newConsignment = db.Consignments.Find(consignment.Id);
            newConsignment.Name = consignment.Name;
            newConsignment.Leader = consignment.Leader;
            newConsignment.Locations.Clear();
            if (selectedLocations != null)
            {
                foreach (var l in db.Locations.Where(lo => selectedLocations.Contains(lo.Id)))
                {
                    newConsignment.Locations.Add(l);
                }
            }

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

            var consignment = db.Consignments.Find(id);
            ViewBag.Consignment = consignment;
            return View(consignment);
        }
    }
}