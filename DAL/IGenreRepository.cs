using Domain;
using System.Collections.Generic;

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
