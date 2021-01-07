using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class Accueil : Form
    {
        private IAllAlbumsRepository tousLesAlbumsRepository;
        private IMyAlbumsRepository mesAlbumsRepository;
        private IWishlistRepository wishlistRepository;

        public Accueil()
        {
            InitializeComponent();
        }

        private void AfficherContenu()
        {
           /* try
            {
                dgvUtils.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des utilisateurs et remplissage du tableau
                foreach (Utilisateur utilisateur in utilisateurRepository.GetAll())
                {
                    dgvUtils.Rows.Add(utilisateur.Decrire());
                }
                // tri sur la 1ère colonne (nom)
                dgvUtils.Sort(dgvUtils.Columns[0], ListSortDirection.Ascending);

                dgvLivres.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des livres et remplissage du tableau
                foreach (Livre livre in livreRepository.GetAll())
                {
                    dgvLivres.Rows.Add(livre.Decrire());
                }
                // tri sur la 1ère colonne (ISBN)
                dgvLivres.Sort(dgvLivres.Columns[0], ListSortDirection.Ascending);

                dgvEmprunts.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des emprunts et remplissage du tableau
                foreach (Emprunt emprunt in empruntRepository.GetAll())
                {
                    string date = emprunt.Date.ToShortDateString();
                    string emprunteur = emprunt.Emprunteur.ToString();
                    string livre = emprunt.Livre.Titre;
                    string rendu = emprunt.Rendu.ToString();

                    string[] ligne = { date, emprunteur, livre, rendu };
                    dgvEmprunts.Rows.Add(ligne);
                }
                // tri sur la 1ère colonne (date de l'emprunt)
                dgvEmprunts.Sort(dgvEmprunts.Columns[0], ListSortDirection.Descending);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void btn_MyAlbums_Click(object sender, EventArgs e)
        {
            MyAlbums mesAlbums = new MyAlbums();
            mesAlbums.Show();
        }


        private void btn_Accueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
        }

        private void btn_AllAlbums_Click(object sender, EventArgs e)
        {
            AllAlbums tousLesAlbums = new AllAlbums();
            tousLesAlbums.Show();
        }

        private void btn_Wishlist_Click(object sender, EventArgs e)
        {
            WishList maWishlist = new WishList();
            maWishlist.Show();
        }

        private void link_Deconnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
