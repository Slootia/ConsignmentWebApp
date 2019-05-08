using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsignmentsWebApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public int ConsignmentsId { get; set; }
        public int LocationId { get; set; }
        public int Members { get; set; }
    }
}