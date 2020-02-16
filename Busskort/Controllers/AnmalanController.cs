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
            // Create a dropdown with ViewBag from a class
            DropdownList dropdown = new DropdownList();
            ViewBag.DropDownYears = dropdown.GetYearDropDown();

            return View();
        }

        [HttpPost]
        [ValidateInput(true)] // Prevent XSS
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // Use class from reference, otherwise errors will occur when passing the object to the service
                BusskortServiceReference.Anmälan newAnmälan = new BusskortServiceReference.Anmälan();

                // Skola och årskurs
                newAnmälan.Årskurs = Convert.ToInt32(collection["year"]);
                newAnmälan.Skola = Convert.ToString(collection["skolaNamn"]);

                // Barn
                newAnmälan.barnPersonnummer = Convert.ToInt32(collection["barnPersonnummer"]);
                newAnmälan.barnFörnamn = Convert.ToString(collection["barnFörnamn"]);
                newAnmälan.barnEfternamn = Convert.ToString(collection["barnEfternamn"]);

                // Målsman
                newAnmälan.FörälderPersonnummer = Convert.ToInt32(collection["FörälderPersonnummer"]);
                newAnmälan.Förnamn = Convert.ToString(collection["Förnamn"]);
                newAnmälan.Efternamn = Convert.ToString(collection["Efternamn"]);

                //Kontakt 
                newAnmälan.E_post = Convert.ToString(collection["E_post"]);
                newAnmälan.Telefon = Convert.ToInt32(collection["inputTelefon"]);

                // Adress
                newAnmälan.Adress = Convert.ToString(collection["Adress"]);
                newAnmälan.Postnummer = Convert.ToInt32(collection["Postnummer"]);
                newAnmälan.Ort = Convert.ToString(collection["Ort"]);

                BusskortServiceReference.Service1Client client = new BusskortServiceReference.Service1Client();
                EmailHandler email = new EmailHandler();

                // Insert into database
                client.CreateAnmälan(newAnmälan);
                email.CreateRegistrationEmail("Ansökan om busskort", newAnmälan);
            }
            catch
            {

            }

            return RedirectToAction("Index");
        }
    }
}