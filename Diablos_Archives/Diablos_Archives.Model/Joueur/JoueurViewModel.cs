﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablos_Archives.Model
{
    public class JoueurViewModel
    {
        public decimal? TailleCm { get; set; }
        public decimal? PoidsKg { get; set; }
        public string EcoleSecondaire { get; set; }
        public string VilleNatale { get; set; }
        public string DomaineEtude { get; set; }
        public virtual Personne Personne { get; set; }
    }
}
