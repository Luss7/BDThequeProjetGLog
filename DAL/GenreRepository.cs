using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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
