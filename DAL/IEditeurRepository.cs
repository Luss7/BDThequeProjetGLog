using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface IEditeurRepository
    {
        //Récupère la liste des editeurs
        IList<Editeur> GetAll();

        //Sauvegarde un editeur
        void Save(Editeur editeur);
    }
}
