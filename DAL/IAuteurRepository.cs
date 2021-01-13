using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface IAuteurRepository
    {
        //Récupère la liste des auteurs
        List<Auteur> GetAll();

        //Sauvegarde un auteur
        void Save(Auteur auteur);
    }
}
