using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class AuteurRepository : Repository, IAuteurRepository
    {
        public void Save(Auteur auteur)
        {
            Session.SaveOrUpdate(auteur);
            Session.Flush();
        }

        public IList<Auteur> GetAll()
        {
            return Session.Query<Auteur>().ToList();
        }
    }
}
