using System.Collections.Generic;

namespace Domain
{
    public class Utilisateur
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }
        public virtual bool EstAdmin { get; set; }
        public virtual IList<Album> Bibliotheque { get; set; }
        public virtual IList<Album> Wishlist { get; set; }
        public Utilisateur()
        {
            Bibliotheque = new List<Album>();
            Wishlist = new List<Album>();
        }
        public Utilisateur(string login, string mdp, bool estAdmin) : this()
        {
            Login = login;
            Mdp = mdp;
            EstAdmin = estAdmin;
        }
        public void Acheter(Album album)
        {
            Wishlist.Remove(album);
            Bibliotheque.Add(album);
        }

    }
}
