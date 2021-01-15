using Domain;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class CategorieRepository : Repository, ICategorieRepository
    {
        public void Save(Categorie categorie)
        {
            Session.SaveOrUpdate(categorie);
            Session.Flush();
        }

        public IList<Categorie> GetAll()
        {
            return Session.Query<Categorie>().ToList();
        }
    }
}
