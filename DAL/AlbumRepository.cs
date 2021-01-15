using Domain;
using NHibernate;
using NHibernate.Criterion;
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

        public IList<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }

        public IList<Album> GetAlbumsCategorie(string nomCategorie) 
        {
            return Session.Query<Album>().Where(x => x.Categorie.Nom == nomCategorie).ToList();
        }
        public IList<Album> GetAlbumsGenres(string nomGenre)
        {
            return Session.QueryOver<Album>().JoinQueryOver<Genre>(a => a.Genres).Where(g => g.Nom == nomGenre).List();
        }

    }
}
