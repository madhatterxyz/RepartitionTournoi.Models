namespace RepartitionTournoi.Models
{
    public class JeuDTO
    {
        public JeuDTO(long id, string nom, int nbJoueursMin, int nbJoueursMax)
        {
            Id = id;
            Nom = nom;
            NbJoueursMin = nbJoueursMin;
            NbJoueursMax = nbJoueursMax;
        }
    
        public long Id { get; set; }
        public string Nom { get; set; }
        public int NbJoueursMin { get; set; }
        public int NbJoueursMax { get; set; }

    }
}
