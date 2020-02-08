using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Busskort.Models;

namespace Busskort.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            List<Anmälan> AnmälanList = new List<Anmälan>();
            BusskortViewModel model = new BusskortViewModel();
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();

            var temp = client.GetAnmälanList();

            foreach (var item in temp)
            {
                Anmälan tempAnmälan = new Anmälan();
                tempAnmälan.ID = item.ID;
                tempAnmälan.Förnamn = item.Förnamn;
                tempAnmälan.Efternamn = item.Efternamn;
                tempAnmälan.barnPersonnummer = item.barnPersonnummer;
                tempAnmälan.barnFörnamn = item.barnFörnamn;
                tempAnmälan.barnEfternamn = item.barnEfternamn;
                tempAnmälan.Adress = item.Adress;
                tempAnmälan.Postnummer = item.Postnummer;
                tempAnmälan.E_post = item.E_post;
                tempAnmälan.Ort = item.Ort;
                tempAnmälan.Årskurs = item.Årskurs;
                tempAnmälan.Skola = item.Skola;
                AnmälanList.Add(tempAnmälan);
            }

            model.AnmälanList = AnmälanList;

            return View(model);
        }
    }
}