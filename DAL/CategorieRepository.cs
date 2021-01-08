using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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
