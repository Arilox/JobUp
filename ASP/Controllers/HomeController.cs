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
        public System.Web.Mvc.ActionResult Index()
        {
            return View();
        }

        public System.Web.Mvc.ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public System.Web.Mvc.ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}