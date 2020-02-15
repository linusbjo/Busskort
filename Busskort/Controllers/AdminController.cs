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

            // Send the selected Year value
            ViewBag.DropDownYears = dropdown.GetSelectedValueFromDropDownYear(anmälan.Årskurs);

            return View(anmälan);
        }

        // When edit is submit
        [HttpPost]
        [ValidateInput(true)]
        public ActionResult EditConfirmed(FormCollection collection)
        {
            BusskortServiceReference.Anmälan anmälan = new BusskortServiceReference.Anmälan();
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            EmailHandler email = new EmailHandler();

            anmälan.ID = Convert.ToInt32(collection["ID"]);

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
            string Subject;

            // Checks if denied or not
            if(anmälan.Beviljad.ToLower() == "ja")
            {
                Subject = "Ansökan om busskort - beviljat";
            }
            else
            {
                Subject = "Ansökan om busskort - nekat";
            }

            // Send subject and object
            email.CreateDecisionEmail(Subject, anmälan);

            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            DropdownList dropdown = new DropdownList();
            ViewBag.DropDownYears = dropdown.GetSelectedValueFromDropDownYear(GetAnmälanByIDFromService(id).Årskurs);

            return View(GetAnmälanByIDFromService(id));
        }
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            client.DeleteAnmälan(id);

            return RedirectToAction("Index");
        }


        #region Internal methods
        private BusskortServiceReference.Anmälan GetAnmälanByIDFromService(int id)
        {
            // Return anmälan by ID
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            return client.GetAnmälan(id);
        }
        private List<BusskortServiceReference.Anmälan> GetAnmälanListFromService()
        {
            // Return the list from the service
            BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
            return client.GetAnmälanList().ToList(); 
        }
        #endregion

    }
}
