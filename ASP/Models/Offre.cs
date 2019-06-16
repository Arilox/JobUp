using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Offre
    {
        public int Id { get; set; }

        public string Intitule { get; set; }

        public DateTime Date { get; set; }

        public float Salaire { get; set; }

        public string Description { get; set; }

        public Boolean Statut { get; set; }

        public int ResponsableId { get; set; }

        public Employe Responsable { get; set; }
    }
}