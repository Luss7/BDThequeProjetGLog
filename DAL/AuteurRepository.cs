using Domain;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class AuteurRepository : Repository, IAuteurRepository
    {
        public void Save(Auteur auteur)
        {
            Session.SaveOrUpdate(auteur);
            Session.Flush();
        }

        public List<Auteur> GetAll()
        {
            return Session.Query<Auteur>().ToList();
        }
    }
}
