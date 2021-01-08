using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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
