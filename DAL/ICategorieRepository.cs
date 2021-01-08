using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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
