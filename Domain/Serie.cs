namespace Domain
{
    public class Serie
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public Serie() { }
        public Serie(string nom)
        {
            Nom = nom;
        }
    }
}
