using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BusskortService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Anmälan> GetAnmälanList()
        {
            AnmalanEntityDataModel db = new AnmalanEntityDataModel();

            return db.Anmälan.ToList();
        }

        public Anmälan GetAnmälan(int id)
        {
            AnmalanEntityDataModel db = new AnmalanEntityDataModel();

            return db.Anmälan.Find(id);
        }

        public void DeleteAnmälan(int id)
        {
            AnmalanEntityDataModel db = new AnmalanEntityDataModel();

            db.Anmälan.Remove(db.Anmälan.Find(id)); // Remove by id
            db.SaveChanges();
        }

        public void UpdateAnmälan(Anmälan anmälan)
        {
            Anmälan UpdateAnmälan = new Anmälan();
            AnmalanEntityDataModel db = new AnmalanEntityDataModel();

            UpdateAnmälan = db.Anmälan.Find(anmälan.ID); // Find by id

            UpdateAnmälan.barnPersonnummer = anmälan.barnPersonnummer;
            UpdateAnmälan.barnEfternamn = anmälan.barnEfternamn;
            UpdateAnmälan.barnFörnamn = anmälan.barnFörnamn;
            UpdateAnmälan.Förnamn = anmälan.Förnamn;
            UpdateAnmälan.Efternamn = anmälan.Efternamn;
            UpdateAnmälan.Skola = anmälan.Skola;
            UpdateAnmälan.Årskurs = anmälan.Årskurs;
            UpdateAnmälan.Ort = anmälan.Ort;
            UpdateAnmälan.Adress = anmälan.Adress;
            UpdateAnmälan.Postnummer = anmälan.Postnummer;
            UpdateAnmälan.Beviljad = anmälan.Beviljad;
            UpdateAnmälan.Telefon = anmälan.Telefon;
            UpdateAnmälan.E_post = anmälan.E_post;
            UpdateAnmälan.FörälderPersonnummer = anmälan.FörälderPersonnummer;

            db.SaveChanges();

        }
        public void CreateAnmälan(Anmälan anmälan)
        {
            try
            {
                AnmalanEntityDataModel db = new AnmalanEntityDataModel();
                db.Anmälan.Add(anmälan);
                db.SaveChanges();
            }
            catch (Exception e)
            {

            }

        }
    }
}
