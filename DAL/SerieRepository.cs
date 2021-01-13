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

        public List<Serie> GetAll()
        {
            return Session.Query<Serie>().ToList();
        }
    }
}
