using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IAuteurRepository
    {
        //Récupère la liste des auteurs
        IList<Auteur> GetAll();

        //Sauvegarde un auteur
        void Save(Auteur auteur);
    }
}
