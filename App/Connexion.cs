using Domain;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App
{
    public partial class Connexion : Form
    {
        private IList<Utilisateur> users;
        private Utilisateur user;
        public Connexion(IList<Utilisateur> utilisateurs)
        {
            InitializeComponent();
            users = utilisateurs;
            user = new Utilisateur();
        }

        private void btn_ValiderConnexion_Click(object sender, System.EventArgs e)
        {
            if (users.Count > 0)
            {
                foreach (Utilisateur user in users)
                {
                    if (user.Login == tb_Login.Text)
                    {
                        if (user.Mdp == tb_Mdp.Text)
                        {
                            SetUtilisateur(user);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else MessageBox.Show("Mot de passe incorrect");
                    }
                }
            }
            else MessageBox.Show("Aucun utilisateur récupéré");

        }
        private void SetUtilisateur(Utilisateur utilisateur)
        {
            user = utilisateur;
        }

        public Utilisateur GetUtilisateur()
        {
            return user;
        }
    }
}
