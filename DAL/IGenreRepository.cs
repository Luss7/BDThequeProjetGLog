using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface IGenreRepository
    {
        //Récupère la liste des genres
        List<Genre> GetAll();

        //Sauvegarde un genre
        void Save(Genre genre);
    }
}
