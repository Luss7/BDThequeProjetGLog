using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface ICategorieRepository
    {
        //Récupère la liste des categories
        List<Categorie> GetAll();

        //Sauvegarde une categorie
        void Save(Categorie categorie);
    }
}
