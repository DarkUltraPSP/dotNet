using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services.AnnoncesService
{
    public interface IAnnoncesService
    {
        List<Annonce> Annonce { get; set; }
        List<Etat> Etat { get; set; }
        Task GetAnnonces();
        Task GetSingleAnnonces(int id);
    }
}
