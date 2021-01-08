using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IUtilisateurRepository
    {
        //Récupère la liste des utilisateurs
        IList<Utilisateur> GetAll();

        //Sauvegarde un utilisateur
        void Save(Utilisateur utilisateur);
    }
}
