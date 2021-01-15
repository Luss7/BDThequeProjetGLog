using Domain;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        public IList<Album> GetAlbumsMot(string mot)
        {
            IList<Album> qTitre = Session.Query<Album>().Where(x => x.Titre.IndexOf(mot) >= 0).ToList();
            IList<Album> qSerie = Session.Query<Album>().Where(x => x.Serie.Nom.IndexOf(mot) >= 0).ToList();
            var qAuteurPrenom = Session.QueryOver<Album>().JoinQueryOver<Auteur>(x => x.Auteurs).Where(a => a.Prenom==mot).List();
            var qAuteurNom = Session.QueryOver<Album>().JoinQueryOver<Auteur>(x => x.Auteurs).Where(a => a.Nom==mot).List();
            IList<Album> myList2 = qTitre.Concat(qSerie).Concat(qAuteurPrenom).Concat(qAuteurNom).Distinct().ToList();
            return myList2;
        }

    }
}
