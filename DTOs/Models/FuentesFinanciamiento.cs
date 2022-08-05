﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    public class FuentesFinanciamiento
    {
        public FuentesFinanciamiento()
        {
            Contribuyentes = new HashSet<Contribuyentes>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFuenteFinanciamiento { get; set; }
        public string FuenteFinanciamiento { get; set; }
        public string Obs { get; set; }

        public virtual ICollection<Contribuyentes> Contribuyentes { get; set; }
    }
}
