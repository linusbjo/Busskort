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
        public ActionResult Login()
        {
            return View();
        }

        // GET: Admin
        public ActionResult Index()
        {            
            BusskortViewModel model = new BusskortViewModel();                  
            model.AnmälanList = GetAnmälanListFromService();

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int id)
        {
            Anmälan anmälan = new Anmälan();
            anmälan = GetAnmälanByIDFromService(id);

            return View(anmälan);
        }

        // When edit is submit
        [HttpPost]
        public ActionResult EditConfirmed(FormCollection collection)
        {
            BusskortServiceReference.Anmälan anmälan = new BusskortServiceReference.Anmälan();
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            EmailHandler email = new EmailHandler();

            //TODO: ändra names
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

            email.SendMail(anmälan.E_post, subject, anmälan.Motivering);

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            Anmälan anmälan = new Anmälan();
            anmälan = GetAnmälanByIDFromService(4);

            return View(anmälan);
        }

        #region Internal methods
        private Anmälan GetAnmälanByIDFromService(int id)
        {
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            Anmälan anmälan = new Anmälan();

            var tempAnmälan = client.GetAnmälan(id);

            anmälan.ID = tempAnmälan.ID;
            anmälan.Förnamn = tempAnmälan.Förnamn;
            anmälan.Efternamn = tempAnmälan.Efternamn;
            anmälan.barnPersonnummer = tempAnmälan.barnPersonnummer;
            anmälan.FörälderPersonnummer = tempAnmälan.FörälderPersonnummer;
            anmälan.barnFörnamn = tempAnmälan.barnFörnamn;
            anmälan.barnEfternamn = tempAnmälan.barnEfternamn;
            anmälan.Adress = tempAnmälan.Adress;
            anmälan.Postnummer = tempAnmälan.Postnummer;
            anmälan.E_post = tempAnmälan.E_post;
            anmälan.Ort = tempAnmälan.Ort;
            anmälan.Årskurs = tempAnmälan.Årskurs;
            anmälan.Skola = tempAnmälan.Skola;
            anmälan.Beviljad = tempAnmälan.Beviljad;
            anmälan.Motivering = tempAnmälan.Motivering;
            anmälan.Telefon = tempAnmälan.Telefon;

            return anmälan;
        }
        private List<Anmälan> GetAnmälanListFromService()
        {
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            List<Anmälan> AnmälanList = new List<Anmälan>();
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
