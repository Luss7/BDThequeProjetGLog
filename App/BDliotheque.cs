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
        private List<Album> albums = new List<Album>();
        public BDliotheque(IUtilisateurRepository utilisateurRepository, IAlbumRepository albumRepository)
        {
            InitializeComponent();
            this.utilisateurRepository = utilisateurRepository;
            this.albumRepository = albumRepository;
            utilisateur = utilisateurRepository.GetAll()[0];
            albums = albumRepository.GetAll();
            AfficherContenu();

        }

        private void AfficherContenu()
        {
            List<PictureBox> boxImages = new List<PictureBox>();
            List<Label> labelTitre = new List<Label>();
            //Constructions listes de PictureBox et Label
            for(int i = 1; i <= 15; i++)
            {
                boxImages.Add((PictureBox)Controls.Find("pic_allalb_" + i, true)[0]);
                labelTitre.Add((Label)Controls.Find("lb_titreAlbum" + i, true)[0]);
            }
           
            //Remplissage des PicturesBox et Labels avec les infos des albums
            for (int i = 0; i < 15; i++)
            {
                boxImages[i].Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\DAL\\Images\\", albums[i].ImageCouv)));
                labelTitre[i].Text = albums[i].Titre;
            }

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

        void pictureAlbum_Click(object sender, EventArgs e)
        {
            //envoyer l'album dans infoalbum pour qu'il affiche les infos
                //Récupérer l'album
                    //Récupérer le numero de la picture dans le nom
            PictureBox picture = sender as PictureBox;
            string nom = picture.Name;
            int nb_char_suppr = "pic_allalb_".Length;
            int nb_picture = int.Parse(nom.Substring(nb_char_suppr, nom.Length-nb_char_suppr));
            Album album = albums[nb_picture - 1];

            InfosAlbum infosAlbum = new InfosAlbum(album);
            DialogResult dialog = infosAlbum.ShowDialog();
            if ( dialog == DialogResult.OK)
            {
                utilisateur.Bibliotheque.Add(album);
            }
            else
                if(dialog == DialogResult.Yes)
            {
                utilisateur.Wishlist.Add(album);
            }
            utilisateurRepository.Save(utilisateur);
        }
        private void lb_nom_utilisateur_Click(object sender, EventArgs e)
        {

        }

        private void tabTousAlbums_Click(object sender, EventArgs e)
        {

        }
        
        private void lb_titreAlbum_Click(object sender, EventArgs e)
        {

        }
        

    }
}
