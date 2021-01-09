namespace Domain
{
    public class Categorie
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public Categorie() { }
        public Categorie(string nom)
        {
            Nom = nom;
        }
        public override string ToString()
        {
            return Nom;
        }
    }
}
