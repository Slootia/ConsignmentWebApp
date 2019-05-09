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
            Consignment lpr = new Consignment { Name = "Либертарианская партия России", Leader = "Сергей Бойко" };
            Consignment edro = new Consignment { Name = "Единая Россия", Leader = "Дмитрий Медведев" };
            List<Consignment> consignments = new List<Consignment>
            {
                lpr,
                edro
            };
            db.Consignments.AddRange(consignments);
            db.SaveChanges();

            Location Moscow = new Location { Name = "Московская область", MainCity = "Москва", Population = 10000000 };
            db.Locations.Add(Moscow);
            db.SaveChanges();

            Department lprMoscow = new Department { Name = "Московское отделение ЛПР", LeaderOfDepartment = "SomePerson", Consignment = lpr, MembersCount = 200, Location = Moscow };
            Department edroMoscow = new Department { Name = "Московское отделение Единой России", LeaderOfDepartment = "SomePerson1", Consignment = edro, MembersCount = 5000, Location = Moscow };
            List<Department> departments = new List<Department>
            {
                lprMoscow,
                edroMoscow
            };
            db.Departments.AddRange(departments);
            db.SaveChanges();

            db.Departments.Add(new Department { });
            base.Seed(db);
        }
    }
}