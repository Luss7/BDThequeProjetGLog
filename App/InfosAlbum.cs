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
    public partial class InfosAlbum : Form
    {
        private Album album;
        public InfosAlbum( Album album)
        {
            InitializeComponent();
            this.album = album;
            AfficherContenu();
        }
        private void AfficherContenu() 
        { 
            pb_info.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\DAL\\Images\\", album.ImageCouv)));
            lb_titreInfosAlbum.Text = album.Titre;
            lb_nomSerie.Text = album.Serie.Nom;
            lb_nomCategorie.Text = album.Categorie.Nom;

            IList<Auteur> auteurs = album.Auteurs;
            string nomsAuteurs = "";
            for (int i = 0; i < auteurs.Count; i++)
            {
                if (i > 0) nomsAuteurs += ", ";
                nomsAuteurs += auteurs[i].Prenom+" "+auteurs[i].Nom;
            }
            lb_nomsAuteurs.Text = nomsAuteurs;

            IList<Genre> genres = album.Genres;
            string nomsGenres = "";
            for (int i = 0; i < genres.Count; i++)
            {
                if (i > 0) nomsGenres += " / ";
                nomsGenres += genres[i].Nom;
            }
            lb_nomGenre.Text = nomsGenres;
                      
        }

        private void btn_ajoutMesAlbums_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_ajoutWishlist_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
