using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AJAXCRUDProj.Models
{
    public class Employee
    {
        public int EmpId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
        public decimal Salary { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
    }
}