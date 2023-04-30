using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class Vehicule
    {
        public int IdVehicule { get; set; }
        public string? Marque { get; set; }
        public string? Modele { get; set; }
        public string? Carburant { get; set; }
        public string? BoiteVitesse { get; set; }
        public int Km { get; set; }
        public int Annee { get; set; }
        public int Puissance { get; set; }
        public string? Couleur { get; set; }
        public int Places { get; set; }
        public Annonce? Annonce { get; set; }
        public int IdAnnonce { get; set; }
    }
}
