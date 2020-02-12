using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Busskort.Models;

namespace Busskort.Controllers
{
    public class AnmalanController : Controller
    {
        // GET: Anmalan
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Anmälan newAnmälan = new Anmälan();

            // Skola och årskurs
            newAnmälan.Årskurs = Convert.ToInt32(collection["year"]);
            newAnmälan.Skola = Convert.ToString(collection["skolaNamn"]);

            // Barn
            newAnmälan.barnPersonnummer = Convert.ToInt32(collection["barnPersonnummer"]);
            newAnmälan.barnFörnamn = Convert.ToString(collection["barnFörnamn"]);
            newAnmälan.barnEfternamn = Convert.ToString(collection["barnEfternamn"]);

            // Målsman
            //newAnmälan. = Convert.ToInt32(collection["year"]);
            //newAnmälan.Årskurs = Convert.ToInt32(collection["year"]);
            //newAnmälan.Årskurs = Convert.ToInt32(collection["year"]);
            //newAnmälan.Årskurs = Convert.ToInt32(collection["year"]);
            //newAnmälan.Årskurs = Convert.ToInt32(collection["year"]);
            //newAnmälan.Årskurs = Convert.ToInt32(collection["year"]);
            //newAnmälan.Årskurs = Convert.ToInt32(collection["year"]);
            //newAnmälan.Årskurs = Convert.ToInt32(collection["year"]);

            return View();
        }
    }
}