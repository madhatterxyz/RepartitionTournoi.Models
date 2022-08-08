namespace RepartitionTournoi.Models
{
    public class CompositionDTO
    {
        public List<MatchDTO> Matchs { get; set; }
        public JeuDTO Jeu { get; set; }
        public MatchDTO Match { get; set; }
        public TournoiDTO Tournoi { get; set; }

        public long MatchId { get; set; }
        public long JeuId { get; set; }
        public long TournoiId { get; set; }
    }
}
