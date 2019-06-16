using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Formation
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public string Intitule { get; set; }

        public DateTime Date { get; set; }
    }
}