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
        public virtual IList<Album> Bibliotheque { get; set; }
        public virtual IList<Album> Wishlist { get; set; }
        public Utilisateur() 
        {
            Bibliotheque = new List<Album>();
            Wishlist = new List<Album>();
        }
        public Utilisateur(string login, string mdp) : this()
        {
            Login = login;
            Mdp = mdp;
        }
        public void Acheter(Album album)
        {
            Wishlist.Remove(album);
            Bibliotheque.Add(album);
        }

    }
}
