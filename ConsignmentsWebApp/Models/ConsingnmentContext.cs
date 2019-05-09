using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConsignmentsWebApp.Models
{
    public class ConsingnmentContext : DbContext
    {
        public DbSet<Consignment> Consignments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}