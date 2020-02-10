namespace BusskortService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Anmälan
    {
        public int ID { get; set; }

        public int Årskurs { get; set; }

        [Required]
        [StringLength(50)]
        public string Skola { get; set; }

        public int barnPersonnummer { get; set; }

        [Required]
        [StringLength(50)]
        public string Förnamn { get; set; }

        [Required]
        [StringLength(50)]
        public string Efternamn { get; set; }

        [Required]
        [StringLength(50)]
        public string barnFörnamn { get; set; }

        [Required]
        [StringLength(50)]
        public string barnEfternamn { get; set; }

        [Column("E-post")]
        [Required]
        [StringLength(50)]
        public string E_post { get; set; }

        public int Telefon { get; set; }

        [Required]
        [StringLength(50)]
        public string Adress { get; set; }

        public int Postnummer { get; set; }

        [Required]
        [StringLength(50)]
        public string Ort { get; set; }

        [StringLength(50)]
        public string Beviljad { get; set; }

        [StringLength(50)]
        public string Motivering { get; set; }
    }
}
