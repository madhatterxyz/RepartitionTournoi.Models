namespace RepartitionTournoi.Models
{
    public class JoueurDTO
    {
        public JoueurDTO(long id, string nom, string prénom, string téléphone)
        {
            Id = id;
            Nom = nom;
            Prénom = prénom;
            Téléphone = téléphone;
        }

        public long Id { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public string Téléphone { get; set; }
    }
}
