using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface ISerieRepository
    {
        //Récupère la liste des Series
        List<Serie> GetAll();

        //Sauvegarde une série
        void Save(Serie serie);
    }
}
