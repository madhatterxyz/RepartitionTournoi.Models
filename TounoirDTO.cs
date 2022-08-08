namespace RepartitionTournoi.Models
{
    public class TournoiDTO
    {
        public TournoiDTO()
        {

        }
        public TournoiDTO(long id, string nom)
        {
            Id = id;
            Nom = nom;
            Compositions = new List<CompositionDTO>();
        }
    
        public long Id { get; set; }
        public string Nom { get; set; }
        public List<CompositionDTO> Compositions { get; set; }

    }
}
