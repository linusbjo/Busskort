using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Busskort.Models;

namespace Busskort.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {            
            BusskortViewModel model = new BusskortViewModel();                  
            model.AnmälanList = GetAnmälanListFromService();

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int id)
        {
            DropdownList dropdown = new DropdownList();
            BusskortServiceReference.Anmälan anmälan = new BusskortServiceReference.Anmälan();

            anmälan = GetAnmälanByIDFromService(id);
            ViewBag.DropDownYears = dropdown.GetSelectedValueFromDropDownYear(anmälan.Årskurs);

            return View(anmälan);
        }

        // When edit is submit
        [HttpPost]
        public ActionResult EditConfirmed(FormCollection collection)
        {
            BusskortServiceReference.Anmälan anmälan = new BusskortServiceReference.Anmälan();
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            EmailHandler email = new EmailHandler();

            // Skola och årskurs
            anmälan.Årskurs = Convert.ToInt32(collection["year"]);
            anmälan.Skola = Convert.ToString(collection["skolaNamn"]);

            // Barn
            anmälan.barnPersonnummer = Convert.ToInt32(collection["barnPersonnummer"]);
            anmälan.barnFörnamn = Convert.ToString(collection["barnFörnamn"]);
            anmälan.barnEfternamn = Convert.ToString(collection["barnEfternamn"]);

            // Målsman
            anmälan.FörälderPersonnummer = Convert.ToInt32(collection["FörälderPersonnummer"]);
            anmälan.Förnamn = Convert.ToString(collection["Förnamn"]);
            anmälan.Efternamn = Convert.ToString(collection["Efternamn"]);

            //Kontakt 
            anmälan.E_post = Convert.ToString(collection["E_post"]);
            anmälan.Telefon = Convert.ToInt32(collection["inputTelefon"]);

            // Adress
            anmälan.Adress = Convert.ToString(collection["Adress"]);
            anmälan.Postnummer = Convert.ToInt32(collection["Postnummer"]);
            anmälan.Ort = Convert.ToString(collection["Ort"]);

            // Handläggare
            anmälan.Beviljad = Convert.ToString(collection["beviljad"]);
            anmälan.Motivering = Convert.ToString(collection["motiveringName"]);

            // Update anmälan
            client.UpdateAnmälan(anmälan);
            string subject;

            // Checks if beviljad or not
            if(anmälan.Beviljad.ToLower() == "ja")
            {
                subject = "Ansökan om busskort - nekat";
            }
            else
            {
                subject = "Ansökan om busskort - beviljat";
            }

            email.SendMail(anmälan, subject);

            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            BusskortServiceReference.Anmälan anmälan = new BusskortServiceReference.Anmälan();
            anmälan = GetAnmälanByIDFromService(id);

            return View(anmälan);
        }

        #region Internal methods
        private BusskortServiceReference.Anmälan GetAnmälanByIDFromService(int id)
        {
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            BusskortServiceReference.Anmälan anmälan = new BusskortServiceReference.Anmälan();

            anmälan = client.GetAnmälan(id);
      
            return anmälan;
        }
        private List<BusskortServiceReference.Anmälan> GetAnmälanListFromService()
        {
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            List<BusskortServiceReference.Anmälan> AnmälanList = new List<BusskortServiceReference.Anmälan>();
            var temp = client.GetAnmälanList();

            foreach (var item in temp)
            {
                BusskortServiceReference.Anmälan tempAnmälan = new BusskortServiceReference.Anmälan();
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
                tempAnmälan.Beviljad = item.Beviljad;
                tempAnmälan.Motivering = item.Motivering;
                tempAnmälan.Telefon = item.Telefon;
                tempAnmälan.FörälderPersonnummer = item.FörälderPersonnummer;

                AnmälanList.Add(tempAnmälan);
            }

            return AnmälanList;
        }
        #endregion

    }
}
