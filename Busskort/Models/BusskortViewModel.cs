using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Busskort.Models
{
    public class BusskortViewModel
    {
        public List<Anmälan> AnmälanList { get; set; }
        public Anmälan anmälan { get; set; }
    }
}