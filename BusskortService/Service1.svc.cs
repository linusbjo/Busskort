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

        public void UpdateAnmälan(AnmälanInput anmälanInput)
        {
            Anmälan UpdateAnmälan = new Anmälan();
            AnmalanEntityDataModel db = new AnmalanEntityDataModel();

            UpdateAnmälan = db.Anmälan.Find(anmälanInput.ID); // Find by id

            UpdateAnmälan.barnPersonnummer = anmälanInput.barnPersonnummer;
            UpdateAnmälan.barnEfternamn = anmälanInput.barnEfternamn;
            UpdateAnmälan.barnFörnamn = anmälanInput.barnFörnamn;
            UpdateAnmälan.Förnamn = anmälanInput.Förnamn;
            UpdateAnmälan.Efternamn = anmälanInput.Efternamn;
            UpdateAnmälan.Skola = anmälanInput.Skola;
            UpdateAnmälan.Årskurs = anmälanInput.Årskurs;
            UpdateAnmälan.Ort = anmälanInput.Ort;
            UpdateAnmälan.Adress = anmälanInput.Adress;
            UpdateAnmälan.Postnummer = anmälanInput.Postnummer;
            UpdateAnmälan.Beviljad = anmälanInput.Beviljad;
            UpdateAnmälan.Telefon = anmälanInput.Telefon;
            UpdateAnmälan.E_post = anmälanInput.E_post;

            db.SaveChanges();

        }
        public void CreateAnmälan(AnmälanInput anmälanInput)
        {
            Anmälan NewAnmälan = new Anmälan();
            AnmalanEntityDataModel db = new AnmalanEntityDataModel();

            NewAnmälan.barnPersonnummer = anmälanInput.barnPersonnummer;
            NewAnmälan.barnEfternamn = anmälanInput.barnEfternamn;
            NewAnmälan.barnFörnamn = anmälanInput.barnFörnamn;
            NewAnmälan.Förnamn = anmälanInput.Förnamn;
            NewAnmälan.Efternamn = anmälanInput.Efternamn;
            NewAnmälan.Skola = anmälanInput.Skola;
            NewAnmälan.Årskurs = anmälanInput.Årskurs;
            NewAnmälan.Ort = anmälanInput.Ort;
            NewAnmälan.Adress = anmälanInput.Adress;
            NewAnmälan.Postnummer = anmälanInput.Postnummer;
            NewAnmälan.Beviljad = anmälanInput.Beviljad;
            NewAnmälan.Telefon = anmälanInput.Telefon;
            NewAnmälan.E_post = anmälanInput.E_post;

            db.Anmälan.Add(NewAnmälan);

            db.SaveChanges();

        }
    }
}
