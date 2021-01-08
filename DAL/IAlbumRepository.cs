using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IAlbumRepository
    {
        //Récupère la liste des albums
        IList<Album> GetAll();

        //Sauvegarde un album
        void Save(Album album);
    }
}
