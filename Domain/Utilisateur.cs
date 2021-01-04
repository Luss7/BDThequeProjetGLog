using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Utilisateur
    {
        public virtual int Id { get; set; }
        public virtual string Login  { get; set; }
        public virtual string Mdp { get; set; }
        public virtual bool IsAdmin { get; set; }

        private List<Album> _bibliotheque = new List<Album>();

        private List<Album> _wishlist = new List<Album>();

        public Utilisateur() { }
        public Utilisateur(string login, string mdp)
        {
            Login = login;
            Mdp = mdp;
        }

        public List<Album> Bibliotheque
        {
            get
            { return _bibliotheque; }
        }
        public void AddAlbumBibliothèque(Album album)
        {
            _bibliotheque.Add(album);
        }

        public List<Album> Wishlist
        {
            get
            { return _wishlist; }
        }
        public void AddAlbumWishlist(Album album)
        {
            _wishlist.Add(album);
        }

        public void Acheter(Album album)
        {
            _wishlist.Remove(album);
            AddAlbumBibliothèque(album);
        }

    }
}
