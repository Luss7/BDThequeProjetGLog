using Domain;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class SerieRepository : Repository, ISerieRepository
    {
        public void Save(Serie serie)
        {
            Session.SaveOrUpdate(serie);
            Session.Flush();
        }

        public IList<Serie> GetAll()
        {
            return Session.Query<Serie>().ToList();
        }
    }
}
