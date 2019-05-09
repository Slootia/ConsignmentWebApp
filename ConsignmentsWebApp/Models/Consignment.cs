using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsignmentsWebApp.Models
{
    public class Consignment
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Leader { get; set; } 
        //Для 3 НФ, следует вынести Leader в Role, а самих людей в People. Так в нескольких моделях
    }
}