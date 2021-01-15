using Domain;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class GenreRepository : Repository, IGenreRepository
    {
        public void Save(Genre genre)
        {
            Session.SaveOrUpdate(genre);
            Session.Flush();
        }

        public IList<Genre> GetAll()
        {
            return Session.Query<Genre>().ToList();
        }
    }
}
