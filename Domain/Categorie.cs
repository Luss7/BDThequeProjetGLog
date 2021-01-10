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

        /// <summary>
        /// Décrit une catégorie sous forme d'un tableau
        /// </summary>
        /// <returns>Un tableau contenant les propriétés de l'utilisateur</returns>
        public virtual string[] Decrire()
        {
            return new string[] { Nom };
        }

        /// <summary>
        /// Décrit une catégorie sous forme textuelle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nom;
        }
    }
}
