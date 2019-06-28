using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Modele;
using Modele.Entities;

namespace ASP.Controllers
{
    [BindProperties]
    public class HomeController : Controller
    {
        public MappingMetierBase db {get; set;} = new MappingMetierBase();
        public System.Web.Mvc.ActionResult Index()
        {
            List<Employe> employes = db.Employes.ToList();
            Console.WriteLine(employes);
            return View(employes);
        }

        public System.Web.Mvc.ActionResult About()
        {
            ViewBag.Message = "Trouvez l'offre qui corresponds à vos besoins et postulez ! :)";
            List<Offre> offres = db.Offres.ToList();

            return View(offres);
        }

        public System.Web.Mvc.ActionResult Postuler(int id)
        {
            Status s = new Status();
            s.Id = id;
            s.Libele = "En attente";
            Postulation p = new Postulation();
            p.EmployeeId = 1;
            p.Date = DateTime.Now;
            p.Status = s; ;
            if (!db.Postulations.Any(item => item.Id == id))
            {
                db.Postulations.Add(p);
                db.SaveChanges();
                var data = new { response = "ok" };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var data = new { response = "ko" };
                return HttpNotFound();
            }
        }

        public System.Web.Mvc.ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}