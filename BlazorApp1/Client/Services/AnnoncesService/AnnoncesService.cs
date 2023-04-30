using BlazorApp1.Shared;
using System.Net.Http.Json;

namespace BlazorApp1.Client.Services.AnnoncesService
{
    public class AnnoncesService : IAnnoncesService
    {
        private readonly HttpClient _http;
        public AnnoncesService(HttpClient http)
        {
            _http = http;
        }

        public List<Annonce> Annonce { get; set; } = new List<Annonce>();
        public List<Etat> Etat { get; set ; } = new List<Etat> ();

        public async Task GetAnnonces()
        {
            var result = await _http.GetFromJsonAsync<List<Annonce>>("");
            if (result == null)
            {
                Annonce = result;
            }
        }

        public Task GetSingleAnnonces(int id)
        {
            throw new NotImplementedException();
        }
    }
}
