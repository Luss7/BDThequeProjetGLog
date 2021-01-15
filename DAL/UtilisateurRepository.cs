using Domain;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UtilisateurRepository : Repository, IUtilisateurRepository
    {
        public void Save(Utilisateur utilisateur)
        {
            Session.SaveOrUpdate(utilisateur);
            Session.Flush();
        }

        public IList<Utilisateur> GetAll()
        {
            return Session.Query<Utilisateur>().ToList();
        }
    }
}
