using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ConsignmentsWebApp.Models
{
    public class ConsignmentsDbInitializer : DropCreateDatabaseAlways<ConsingnmentContext>
    {
        protected override void Seed(ConsingnmentContext db)
        {
            db.Consignments.Add(new Consignment { Name = "Либертарианская партия России" });
            db.Consignments.Add(new Consignment { Name = "Единая Россия" });
            db.Consignments.Add(new Consignment { Name = "Коммунистическая партия России" });
            db.Consignments.Add(new Consignment { Name = "Либерально-демократическая партия России" });
            db.Consignments.Add(new Consignment { Name = "Справедливая Россия" });
            base.Seed(db);
        }
    }
}