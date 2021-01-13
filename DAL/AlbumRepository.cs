using Domain;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class AlbumRepository : Repository, IAlbumRepository
    {
        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }

        public List<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }
    }
}
