using DAL;
using Domain;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace App
{
    public partial class Accueil : Form
    {
        private IAlbumRepository albumRepository;
        private IAuteurRepository auteurRepository;
        private ICategorieRepository categorieRepository;
        private IEditeurRepository editeurRepository;
        private IGenreRepository genreRepository;
        private ISerieRepository serieRepository;
        private IUtilisateurRepository utilisateurRepository;


        public Accueil()
        {
            InitializeComponent();
        }


        public Accueil(IAlbumRepository albumRepository, IAuteurRepository auteurRepository, ICategorieRepository categorieRepository, IEditeurRepository editeurRepository, IGenreRepository genreRepository, ISerieRepository serieRepository, IUtilisateurRepository utilisateurRepository)
        {
            InitializeComponent();

            this.albumRepository = albumRepository;
            this.auteurRepository = auteurRepository;
            this.categorieRepository = categorieRepository;
            this.editeurRepository = editeurRepository;
            this.genreRepository = genreRepository;
            this.serieRepository = serieRepository;
            this.utilisateurRepository = utilisateurRepository;

           // AfficherContenu();
        }

    /*   private void AfficherContenu()
        {
            try
            {
                dgvUtils.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des albums et remplissage du tableau
                foreach (Album album in albumRepository.GetAll())
                {
                    dgvUtils.Rows.Add(album.Decrire());
                }
                // tri sur la 1ère colonne (nom)
                dgvUtils.Sort(dgvUtils.Columns[0], ListSortDirection.Ascending);

                dgvLivres.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des auteurs et remplissage du tableau
                foreach (Auteur auteur in auteurRepository.GetAll())
                {
                    dgvLivres.Rows.Add(auteur.Decrire());
                }
                // tri sur la 1ère colonne (ISBN)
                dgvLivres.Sort(dgvLivres.Columns[0], ListSortDirection.Ascending);

                dgvLivres.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des catégories et remplissage du tableau
                foreach (Categorie categorie in categorieRepository.GetAll())
                {
                    dgvLivres.Rows.Add(categorie.Decrire());
                }
                // tri sur la 1ère colonne (ISBN)
                dgvLivres.Sort(dgvLivres.Columns[0], ListSortDirection.Ascending);


                dgvLivres.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des genres et remplissage du tableau
                foreach (Genre genre in genreRepository.GetAll())
                {
                    dgvLivres.Rows.Add(genre.Decrire());
                }
                // tri sur la 1ère colonne (ISBN)
                dgvLivres.Sort(dgvLivres.Columns[0], ListSortDirection.Ascending);


                dgvLivres.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des series et remplissage du tableau
                foreach (Serie serie in serieRepository.GetAll())
                {
                    dgvLivres.Rows.Add(serie.Decrire());
                }
                // tri sur la 1ère colonne (ISBN)
                dgvLivres.Sort(dgvLivres.Columns[0], ListSortDirection.Ascending);
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

        }
    }
}
