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
        BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();

        public ActionResult Login()
        {     
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserProfile user)
        {
            if(client.CheckUser(user.UserName, user.Password))
            {
                Session["ValidUser"] = user.UserName;
                return RedirectToAction("Index", "Admin");               
            }

            return RedirectToAction("Login", "Admin");
        }
        public ActionResult Index()
        {
            if (Session["ValidUser"] == null)
            {
                return RedirectToAction("Login");
            }

            BusskortViewModel model = new BusskortViewModel();
            model.AnmälanList = GetAnmälanListFromService();

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int id)
        {
            if (Session["ValidUser"] == null)
            {
                return RedirectToAction("Login");
            }

       
            BusskortServiceReference.Anmälan anmälan = new BusskortServiceReference.Anmälan();

            anmälan = GetAnmälanByIDFromService(id);

            CreateDropDowns(anmälan, true);

            return View(anmälan);
        }

        // When edit is submit
        [HttpPost]
        [ValidateInput(true)] // use against XSS
        public ActionResult EditConfirmed(FormCollection collection)
        {
            if (Session["ValidUser"] == null)
            {
                return RedirectToAction("Login");
            }

            BusskortServiceReference.Anmälan anmälan = new BusskortServiceReference.Anmälan();
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
            if (Session["ValidUser"] == null)
            {
                return RedirectToAction("Login");
            }

            BusskortServiceReference.Anmälan anmälan = new BusskortServiceReference.Anmälan();
            anmälan = GetAnmälanByIDFromService(id);

            CreateDropDowns(anmälan, true);
           
            return View(anmälan);
        }
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            client.DeleteAnmälan(id);

            return RedirectToAction("Index");
        }


        #region Internal methods
        private BusskortServiceReference.Anmälan GetAnmälanByIDFromService(int id)
        {
            // Return anmälan by ID
            return client.GetAnmälan(id);
        }
        private List<BusskortServiceReference.Anmälan> GetAnmälanListFromService()
        {
            // Return the list from the service
            return client.GetAnmälanList().ToList(); 
        }
        private void CreateDropDowns(BusskortServiceReference.Anmälan anmälan, bool GetSelectedValue)
        {
            DropdownList dropdown = new DropdownList();
            if (GetSelectedValue)
            {              
                ViewBag.DropDownYears = dropdown.GetSelectedValueFromDropDownYear(anmälan.Årskurs); // Årskurs always has a value, Beviljad does not

                if (anmälan.Beviljad != null)
                {
                    ViewBag.DropDownBeviljad = dropdown.GetSelectedValueFromBeviljadDropDown(anmälan.Beviljad);
                }
                else
                {
                    ViewBag.DropDownBeviljad = dropdown.GetBeviljadDropDown();
                }
            }
        }
        #endregion

    }
}
