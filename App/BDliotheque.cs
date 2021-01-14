using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class BDliotheque : Form
    {
        private IUtilisateurRepository utilisateurRepository;
        private IAlbumRepository albumRepository;
        private Utilisateur utilisateur;
        public BDliotheque(IUtilisateurRepository utilisateurRepository, IAlbumRepository albumRepository)
        {
            InitializeComponent();
            this.utilisateurRepository = utilisateurRepository;
            this.albumRepository = albumRepository;
            utilisateur = utilisateurRepository.GetAll()[0];
            AfficherContenu();

        }

        private void AfficherContenu()
        {
            List<Album> albums = albumRepository.GetAll();
            List<PictureBox> boxImages = new List<PictureBox>();
            List<Label> labelTitre = new List<Label>();
            //Affichage images
            for(int i = 1; i <= 15; i++)
            {
                boxImages.Add((PictureBox)Controls.Find("pic_allalb_" + i, true)[0]);
                labelTitre.Add((Label)Controls.Find("lb_titreAlbum" + i, true)[0]);
            }
           
/*            foreach (Control c in tabTousAlbums.Controls)
            {
                if (c is PictureBox)
                {
                    boxImages.Add((PictureBox)c);
                }
                if(c is Label)
                {
                    labelTitre.Add((Label)c);
                }
            }*/
            for (int i = 0; i < 15; i++)
            {
                boxImages[i].Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\DAL\\Images\\", albums[i].ImageCouv)));
                labelTitre[i].Text = albums[i].Titre;
            }

            //Affichage TitreBD


        }

        private void Refresh_Utilisateurs()
        {
            lb_nom_utilisateur.Text = utilisateur.Login;
            link_Deconnexion.Text = "Déconnexion";
        }

        private void Ouvrir_Connexion()
        {
            Connexion connexion = new Connexion(utilisateurRepository.GetAll());
            if (connexion.ShowDialog() == DialogResult.OK)
            {
                utilisateur = connexion.GetUtilisateur();
                Refresh_Utilisateurs();
            }
        }
        private void BDliotheque_Load(object sender, EventArgs e)
        {
            Refresh_Utilisateurs();

        }

        private void link_Deconnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ouvrir_Connexion();
        }

        private void lb_nom_utilisateur_Click(object sender, EventArgs e)
        {

        }

        private void tabTousAlbums_Click(object sender, EventArgs e)
        {

        }

        private void lb_titreAlbum1_Click(object sender, EventArgs e)
        {

        }
    }
}
