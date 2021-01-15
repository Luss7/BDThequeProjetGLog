using System.Collections.Generic;

namespace Domain
{
    public class Utilisateur
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }
        public virtual IList<Album> Bibliotheque { get; set; }
        public virtual IList<Album> Wishlist { get; set; }
        public Utilisateur() { }
        public Utilisateur(string login, string mdp)
        {
            Bibliotheque = new List<Album>();
            Wishlist = new List<Album>();
            Login = login;
            Mdp = mdp;
        }


    }
}
