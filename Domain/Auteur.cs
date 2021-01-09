namespace Domain
{
    public class Auteur
    {
        public virtual int Id { get; set; }
        public virtual string Prenom { get; set; }
        public virtual string Nom { get; set; }
        public Auteur() { }
        public Auteur(string prenom, string nom)
        {
            Prenom = prenom;
            Nom = nom;
        }

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }
    }
}

