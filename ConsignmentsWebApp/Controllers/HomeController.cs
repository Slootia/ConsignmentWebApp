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
        ConsingnmentContext context = new ConsingnmentContext();

        public ActionResult Index()
        {
            IEnumerable<Consignment> consignments = context.Consignments;
            ViewBag.Consignments = consignments;
            return View();
        }

        //public ActionResult More()
        //{
        //    return ;
        //}
    }
}