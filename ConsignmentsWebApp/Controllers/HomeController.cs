using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsignmentsWebApp.Models;

namespace ConsignmentsWebApp.Controllers
{
    public class HomeController : Controller
    {
        readonly ConsingnmentContext context = new ConsingnmentContext();

        public ActionResult Index()
        {
            IEnumerable<Consignment> consignments = context.Consignments;
            ViewBag.Consignments = consignments;
            return View();
        }

        [HttpGet]
        public ActionResult More(int? id)
        {
            //TODO: Добавить проверку на null у id
            IEnumerable<Consignment> consignments = context.Consignments;
            ViewBag.Consignments = consignments;
            ViewBag.Id = id;
            return View();
        }
    }
}