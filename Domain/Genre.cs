﻿namespace Domain
{
    public class Genre
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public Genre() { }
        public Genre(string nom)
        {
            Nom = nom;
        }

        /// <summary>
        /// Décrit un genre sous forme d'un tableau
        /// </summary>
        /// <returns>Un tableau contenant les propriétés de l'utilisateur</returns>
        public virtual string[] Decrire()
        {
            return new string[] { Nom };
        }

        /// <summary>
        /// Décrit un genre sous forme textuelle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nom;
        }
    }
}
