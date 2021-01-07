namespace Domain
{
    class Genre
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public Genre() { }
        public Genre(string nom)
        {
            Nom = nom;
        }
    }
}
