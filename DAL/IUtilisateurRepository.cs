using Domain;
using System.Collections.Generic;

namespace DAL
{
    public interface IUtilisateurRepository
    {
        //Récupère la liste des utilisateurs
        List<Utilisateur> GetAll();

        //Sauvegarde un utilisateur
        void Save(Utilisateur utilisateur);
    }
}
