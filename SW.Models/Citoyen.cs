namespace SW.Models
{
    public class Citoyen
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public Espece Espece { get; set; }
        public Citoyen? PereBiologique { get; set; }
        public Citoyen? MereBiologique { get; set; }
    }
}