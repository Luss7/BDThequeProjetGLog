using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Album
    {
        public virtual int Id { get; set; }
        public virtual string ImageCouv { get; set; } //image sous forme d'un lien, voir comment l'afficher et stocker
        public virtual string Titre { get; set; }
        public Categorie Categorie { get; set; }
        public Serie Serie { get; set; }

        private List<Genre> _genres = new List<Genre>();

        private List<Auteur> _auteurs = new List<Auteur>();
        public Editeur Editeur { get; set; }
     
        public Album() { }

        public Album(string imagecouv, string titre, Categorie categorie, Editeur editeur, Serie serie)
            : this(imagecouv, titre, categorie, editeur)
        {
            Serie = serie;
        }
        public Album(string imagecouv, string titre, Categorie categorie, Editeur editeur)
        {
            ImageCouv = imagecouv;
            Titre = titre;
            Categorie = categorie;
            Editeur = editeur;
        }
        public List<Auteur> Auteurs
        {
            get
            { return _auteurs; }
        }
        public void AddAuteur(Genre genre)
        {
            _genres.Add(genre);
        }

        public List<Genre> Genres
        {
            get
            { return _genres; }
        }
        public void AddGenre(Genre genre)
        {
            _genres.Add(genre);
        }

    }
}
