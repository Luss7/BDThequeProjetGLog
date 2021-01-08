using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class AlbumRepository : Repository, IAlbumRepository
    {
        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }

        public IList<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }
    }
}
