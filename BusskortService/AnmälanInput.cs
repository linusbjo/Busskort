﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusskortService
{
    public class AnmälanInput
    {
        public int ID { get; set; }

        public int Årskurs { get; set; }

        public string Skola { get; set; }

        public int barnPersonnummer { get; set; }

        public string Förnamn { get; set; }

        public string Efternamn { get; set; }

        public string barnFörnamn { get; set; }

        public string barnEfternamn { get; set; }

        public string E_post { get; set; }

        public int Telefon { get; set; }

        public string Adress { get; set; }

        public int Postnummer { get; set; }

        public string Ort { get; set; }

        public bool Beviljad { get; set; }
    }
}