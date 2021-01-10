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

        /// <summary>
        /// Décrit un éditeur sous forme d'un tableau
        /// </summary>
        /// <returns>Un tableau contenant les propriétés de l'utilisateur</returns>
        public virtual string[] Decrire()
        {
            return new string[] { Nom };
        }

        /// <summary>
        /// Décrit un éditeur sous forme textuelle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nom;
        }

    }
}
