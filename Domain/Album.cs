using System.Collections.Generic;

namespace Domain
{
    class Album
    {
        public virtual int Id { get; set; }
        public virtual string ImageCouv { get; set; } //image sous forme d'un nom de fichier, voir comment l'afficher et stocker dans un dossier à part
        public virtual string Titre { get; set; }
        public Categorie Categorie { get; set; }
        public Serie Serie { get; set; }
        public virtual IList<Genre> Genres { get; set; }
        public virtual IList<Auteur> Auteurs { get; set; }
        public Editeur Editeur { get; set; }

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
