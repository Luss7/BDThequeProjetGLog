using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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
