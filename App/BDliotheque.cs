using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace App
{
    public partial class BDliotheque : Form
    {
        private IUtilisateurRepository utilisateurRepository;
        private IAlbumRepository albumRepository;
/*        private ICategorieRepository categorieRepository;
        private IGenreRepository genreRepository;*/
        private Utilisateur utilisateur;
        private IList<Album> albums;
        private IList<Categorie> categories;
        private IList<Genre> genres;
        public BDliotheque(IUtilisateurRepository utilisateurRepository, IAlbumRepository albumRepository,ICategorieRepository categorieRepository, IGenreRepository genreRepository)
        {
            InitializeComponent();
            this.utilisateurRepository = utilisateurRepository;
            this.albumRepository = albumRepository;
/*            this.genreRepository = genreRepository;
            this.categorieRepository = categorieRepository;*/
            utilisateur = utilisateurRepository.GetAll()[0];
            albums = albumRepository.GetAll();
            categories = categorieRepository.GetAll();
            genres = genreRepository.GetAll();
            AfficherTousAlbums();
        }

        private void InitRecherche()
        {
            // Ajout des catégories dans la liste déroulante
            comboBox_Catégorie.Items.AddRange(categories.ToArray<Categorie>());
            if (comboBox_Catégorie.Items.Count > 0)
            {
                // sélection du 1er élément de la liste
                comboBox_Catégorie.SelectedIndex = 0;
            }
            comboBox_Genre.Items.AddRange(genres.ToArray<Genre>());
            if (comboBox_Genre.Items.Count > 0)
            {
                // sélection du 1er élément de la liste
                comboBox_Genre.SelectedIndex = 0;
            }
        }
        private void AfficherTousAlbums()
        {
            List<PictureBox> boxImages = new List<PictureBox>();
            List<Label> labelTitre = new List<Label>();
            //Constructions listes de PictureBox et Label
            for (int i = 1; i <= 15; i++)
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
            AfficheListAlbum(utilisateur.Bibliotheque, tabMesAlbums);
            AfficheListAlbum(utilisateur.Wishlist, tabWishlist);
            InitRecherche();
        }
        private void ViderTab(TabPage tabPage)
        {
            List<Control> listControl = new List<Control>();
            foreach (Control control in tabPage.Controls)
            {
                listControl.Add(control);
            }
            foreach (Control control in listControl)
            {
                string nom = control.Name;
                if (nom.StartsWith("pb_Albums") || nom.StartsWith("lb_AlbumsTitre"))
                    tabPage.Controls.Remove(control);
            }
        }
        private void AfficheListAlbum(IList<Album> listAlbums, TabPage tabPage)
        {

            int i = 0, k = 0;
            if (tabPage == tabRecherche) k = 20;
            int locationX = 256; //+256 = + i mod 4 *256
            int locationY = 345; //+345 ->i = 5, *2 -> i = 9 -> (i-1)/4*345
            foreach (Album monAlbum in listAlbums)
            {
                var image = new PictureBox
                {
                    Name = "pb_Albums" + i.ToString(),
                    Size = new Size(208, 235),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(45+k + (i % 3) * locationX, 102+k + i / 3 * locationY),
                    Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\DAL\\Images\\", monAlbum.ImageCouv))),
                };
                tabPage.Controls.Add(image);

                var titre = new Label
                {
                    Name = "lb_AlbumsTitre" + i.ToString(),
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                    Size = new Size(210, 58),
                    Location = new Point(43+k + (i % 3) * locationX, 354+k + i / 3 * locationY),
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopCenter,
                    Text = monAlbum.Titre,
                };
                tabPage.Controls.Add(titre);
                i++;
            }
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
            int nb_picture = int.Parse(nom.Substring(nb_char_suppr, nom.Length - nb_char_suppr));
            Album album = albums[nb_picture - 1];

            InfosAlbum infosAlbum = new InfosAlbum(album);
            DialogResult dialog = infosAlbum.ShowDialog();
            if (dialog == DialogResult.No)
            {
                utilisateur.Bibliotheque.Add(album);
                utilisateurRepository.Save(utilisateur);
                AfficheListAlbum(utilisateur.Bibliotheque, tabMesAlbums);

/*                if (utilisateur.Wishlist.Contains(album))
                {
                    utilisateur.Wishlist.Remove(album);
                    utilisateurRepository.Save(utilisateur);
                    AfficheListAlbum(utilisateur.Wishlist, tabWishlist);
                }*/
            }

            if (dialog == DialogResult.Yes)
            {
                utilisateur.Wishlist.Add(album);
                utilisateurRepository.Save(utilisateur);
                AfficheListAlbum(utilisateur.Wishlist, tabWishlist);
            }
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

        private void tabMesAlbums_Click(object sender, EventArgs e)
        {

        }

        private void lb_tousLesAlbums_Click(object sender, EventArgs e)
        {

        }

        private void tb_Recherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_rechCategorie_Click(object sender, EventArgs e)
        {
            ViderTab(tabRecherche);
            Categorie categorie = (Categorie)comboBox_Catégorie.SelectedItem;
            IList<Album> albums = albumRepository.GetAlbumsCategorie(categorie.Nom);
            AfficheListAlbum(albums, tabRecherche);
        }

        private void btn_rechGenre_Click(object sender, EventArgs e)
        {
            ViderTab(tabRecherche);
            Genre genre = (Genre)comboBox_Genre.SelectedItem;
            IList<Album> albums = albumRepository.GetAlbumsGenres(genre.Nom);
            AfficheListAlbum(albums, tabRecherche);
        }

        private void btn_rechMot_Click(object sender, EventArgs e)
        {
            ViderTab(tabRecherche);
            string mot = tb_Recherche.Text;
            IList<Album> albums = albumRepository.GetAlbumsMot(mot);
            AfficheListAlbum(albums, tabRecherche);
        }
    }
}
