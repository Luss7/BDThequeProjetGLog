using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface IAlbumRepository
    {
        //Récupère la liste des albums
        List<Album> GetAll();

        //Sauvegarde un album
        void Save(Album album);
    }
}
