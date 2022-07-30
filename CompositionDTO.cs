namespace RepartitionTournoi.Models
{
    public class CompositionDTO
    {
        public IEnumerable<MatchDTO> Matchs { get; set; }
        public JeuDTO Jeu { get; set; }
    }
}
