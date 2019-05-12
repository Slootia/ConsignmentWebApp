using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsignmentsWebApp.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainCity { get; set; }
        public int Population { get; set; }

        public virtual ICollection<Consignment> Consignments { get; set; }
        public Location()
        {
            Consignments = new List<Consignment>();
        }
    }
}