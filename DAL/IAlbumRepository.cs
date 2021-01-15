using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface IAlbumRepository
    {
        //Récupère la liste des albums
        IList<Album> GetAll();

        IList<Album> GetAlbumsCategorie(string nomCategorie);
        IList<Album> GetAlbumsGenres(string nomGenre);
        IList<Album> GetAlbumsMot(string mot);

        //Sauvegarde un album
        void Save(Album album);
    }
}
