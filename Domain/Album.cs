using System.Collections.Generic;

namespace Domain
{
    public class Album
    {
        public virtual int Id { get; set; }
        public virtual string ImageCouv { get; set; } //image sous forme d'un nom de fichier, voir comment l'afficher et stocker dans un dossier à part
        public virtual string Titre { get; set; }
        public virtual Categorie Categorie { get; set; }
        public virtual Serie Serie { get; set; }
        public virtual IList<Genre> Genres { get; set; }
        public virtual IList<Auteur> Auteurs { get; set; }
        public virtual Editeur Editeur { get; set; }

        public Album()
        {
            Genres = new List<Genre>();
            Auteurs = new List<Auteur>();
        }

        public Album(string imagecouv, string titre, Categorie categorie, Editeur editeur, Serie serie)
            : this(imagecouv, titre, categorie, editeur)
        {
            Serie = serie;
        }
        public Album(string imagecouv, string titre, Categorie categorie, Editeur editeur) : this()
        {
            ImageCouv = imagecouv;
            Titre = titre;
            Categorie = categorie;
            Editeur = editeur;
        }

        /// <summary>
        /// Décrit un album sous forme d'un tableau
        /// </summary>
        /// <returns>Un tableau contenant les propriétés de l'utilisateur</returns>
        public virtual string[] Decrire()
        {
            return new string[] { ImageCouv, Titre, Categorie.ToString(), Editeur.ToString() };
        }

        /// <summary>
        /// Décrit un album sous forme textuelle
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string txt = Titre + " " + Serie.ToString() + " " + Categorie.ToString() + " ";
            foreach (Auteur auteur in Auteurs) txt += auteur.ToString() + " ";
            txt += " ";
            foreach (Genre genre in Genres) txt += genre.ToString()+ " ";
            txt+= " " + Editeur.ToString();

            return txt;
        }
    }
}
