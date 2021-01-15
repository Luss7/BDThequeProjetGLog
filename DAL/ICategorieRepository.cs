using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface ICategorieRepository
    {
        //Récupère la liste des categories
        IList<Categorie> GetAll();

        //Sauvegarde une categorie
        void Save(Categorie categorie);
    }
}
