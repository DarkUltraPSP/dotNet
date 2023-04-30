using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnoncesController : ControllerBase
    {
        public static List<Etat> etats = new List<Etat>
        {
            new Etat { 
                IdEtat = 1,
                Libelle = "Disponible"
            },
            new Etat{
                IdEtat = 2,
                Libelle = "Vendue"
            },
            new Etat
            {
                IdEtat = 3,
                Libelle = "En cours de vente"
            }
        };

        public static List<Annonce> annonces = new List<Annonce>
        {
            new Annonce { IdAnnonce = 1,
                Titre = "Poubelle",
                Date = DateTime.UtcNow,
                Description = "Vends MX5 NA, rouille perforante, tourne sur 3 cylindres, interieur pourris",
                Prix = 15000,
                Etat = etats[0]
            },
            new Annonce { IdAnnonce = 2,
                Titre = "lorem ipsum",
                Date = DateTime.UtcNow,
                Description = "lorem ispum",
                Prix = 6000,
                Etat = etats[1]
            },
        };

        [HttpGet]
        public async Task<ActionResult<List<Annonce>>> GetAnnonces()
        {
            return Ok(annonces);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<Annonce>>> GetSingleAnnonces(int id)
        {
            var annonce = annonces.FirstOrDefault(a => a.IdAnnonce == id);
            if (annonce == null)
            {
                return NotFound("Pas d'annonces pour le moment");
            }
            return Ok(annonce);
        }
    }
}
