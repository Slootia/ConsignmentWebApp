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
            Location MoscowDist = new Location { Name = "Московская область", MainCity = "Москва", Population = 10000000 };
            Location SverdlovskDist = new Location { Name = "Свердловская область", MainCity = "Екатеринбург", Population = 1000000 };
            db.Locations.Add(SverdlovskDist);
            db.Locations.Add(MoscowDist);

            Consignment lpr = new Consignment { Name = "Либертарианская партия России",
                Leader = "Сергей Бойко",
                Locations = new List<Location> {MoscowDist, SverdlovskDist } };
            Consignment edro = new Consignment { Name = "Единая Россия", Leader = "Дмитрий Медведев", Locations = new List<Location> { MoscowDist } };

            db.Consignments.Add(lpr);
            db.Consignments.Add(edro);
            db.SaveChanges();
            base.Seed(db);
        }
    }
}