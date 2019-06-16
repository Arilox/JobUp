using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Experience
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public Employe Employe { get; set; }

        public string Intitule { get; set; }

        public int Date { get; set; }
    }
}