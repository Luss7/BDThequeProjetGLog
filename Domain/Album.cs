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
    }
}
