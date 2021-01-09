namespace Domain
{
    public class Editeur
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public Editeur() { }
        public Editeur(string nom)
        {
            Nom = nom;
        }
        public override string ToString()
        {
            return Nom;
        }

    }
}
