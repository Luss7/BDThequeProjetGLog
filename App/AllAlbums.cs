using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AllAlbums : Form
    {
        public AllAlbums()
        {
            InitializeComponent();
        }

        private void comboBox_Genre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Catégorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_Recherche_TextChanged(object sender, EventArgs e)
        {

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

        private void btn_MyAlbums_Click(object sender, EventArgs e)
        {
            MyAlbums mesAlbums = new MyAlbums();
            mesAlbums.Show();
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
