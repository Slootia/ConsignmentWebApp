using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsignmentsWebApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MembersCount { get; set; }
        public string LeaderOfDepartment { get; set; }

        public int? ConsignmentsId { get; set; }
        public Consignment Consignment { get; set; }

        public int? LocationId { get; set; }
        public Location Location{ get; set; }

    }
}