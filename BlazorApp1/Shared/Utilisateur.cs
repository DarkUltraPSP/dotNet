using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    public class Utilisateur
    {
        public int IdUtilisateur { get; set; }
        public string? Pseudo { get; set; }
        public string? mail { get; set; }
        public string? MotDePasse { get; set; }
        public Role Role { get; set; }
        public int IdRole { get; set; }
    }
}
