using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class Annonce
    {
        public int IdAnnonce { get; set; }
        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Prix { get; set; }
        public DateTime Date { get; set; }
        public string Adresse { get; set; } = string.Empty;
        public int CodePostal { get; set; }
        public string Ville { get; set; } = string.Empty;
        public string Pays { get; set; } = string.Empty;
        public Etat? Etat { get; set; }
        public int IdEtat { get; set; }
    }
}
