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

        /// <summary>
        /// Décrit un auteur sous forme d'un tableau
        /// </summary>
        /// <returns>Un tableau contenant les propriétés de l'utilisateur</returns>
        public virtual string[] Decrire()
        {
            return new string[] { Nom, Prenom };
        }

        /// <summary>
        /// Décrit un auteur sous forme textuelle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Prenom + " " + Nom;
        }
    }
}

