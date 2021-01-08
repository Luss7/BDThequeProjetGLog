using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IGenreRepository
    {
        //Récupère la liste des genres
        IList<Genre> GetAll();

        //Sauvegarde un genre
        void Save(Genre genre);
    }
}
