using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface ISerieRepository
    {
        //Récupère la liste des Series
        IList<Serie> GetAll();

        //Sauvegarde une série
        void Save(Serie serie);
    }
}
