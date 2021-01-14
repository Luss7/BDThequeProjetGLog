
namespace App
{
    partial class BDliotheque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tb_Titre = new System.Windows.Forms.TextBox();
            this.tabWishlist = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabMesAlbums = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTousAlbums = new System.Windows.Forms.TabPage();
            this.lab_AllAlbums = new System.Windows.Forms.Label();
            this.tb_Recherche = new System.Windows.Forms.TextBox();
            this.comboBox_Genre = new System.Windows.Forms.ComboBox();
            this.comboBox_Catégorie = new System.Windows.Forms.ComboBox();
            this.lab_Filtrer = new System.Windows.Forms.Label();
            this.lab_SearchGenre = new System.Windows.Forms.Label();
            this.lab_SearchCategorie = new System.Windows.Forms.Label();
            this.lab_SearchKeyWord = new System.Windows.Forms.Label();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.lab_Accueil = new System.Windows.Forms.Label();
            this.lab_ADecouvrir = new System.Windows.Forms.Label();
            this.lab_MyAlbums = new System.Windows.Forms.Label();
            this.lab_Wishlist = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.link_Deconnexion = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lab_nom_utilisateur = new System.Windows.Forms.Label();
            this.lab_utilisateur = new System.Windows.Forms.Label();
            this.tabWishlist.SuspendLayout();
            this.tabMesAlbums.SuspendLayout();
            this.tabTousAlbums.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Titre
            // 
            this.Tb_Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Tb_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Titre.ForeColor = System.Drawing.SystemColors.Info;
            this.Tb_Titre.Location = new System.Drawing.Point(0, 3);
            this.Tb_Titre.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Titre.Name = "Tb_Titre";
            this.Tb_Titre.Size = new System.Drawing.Size(1099, 53);
            this.Tb_Titre.TabIndex = 7;
            this.Tb_Titre.Text = "BD\'LIOTHEQUE";
            this.Tb_Titre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabWishlist
            // 
            this.tabWishlist.Controls.Add(this.label2);
            this.tabWishlist.Location = new System.Drawing.Point(4, 47);
            this.tabWishlist.Name = "tabWishlist";
            this.tabWishlist.Padding = new System.Windows.Forms.Padding(3);
            this.tabWishlist.Size = new System.Drawing.Size(1091, 432);
            this.tabWishlist.TabIndex = 3;
            this.tabWishlist.Text = "Ma wishlist";
            this.tabWishlist.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(430, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ma wishlist";
            // 
            // tabMesAlbums
            // 
            this.tabMesAlbums.Controls.Add(this.label1);
            this.tabMesAlbums.Location = new System.Drawing.Point(4, 47);
            this.tabMesAlbums.Name = "tabMesAlbums";
            this.tabMesAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabMesAlbums.Size = new System.Drawing.Size(1091, 432);
            this.tabMesAlbums.TabIndex = 2;
            this.tabMesAlbums.Text = "Mes albums";
            this.tabMesAlbums.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(416, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mes albums";
            // 
            // tabTousAlbums
            // 
            this.tabTousAlbums.Controls.Add(this.lab_SearchKeyWord);
            this.tabTousAlbums.Controls.Add(this.lab_SearchCategorie);
            this.tabTousAlbums.Controls.Add(this.lab_SearchGenre);
            this.tabTousAlbums.Controls.Add(this.lab_Filtrer);
            this.tabTousAlbums.Controls.Add(this.comboBox_Catégorie);
            this.tabTousAlbums.Controls.Add(this.comboBox_Genre);
            this.tabTousAlbums.Controls.Add(this.tb_Recherche);
            this.tabTousAlbums.Controls.Add(this.lab_AllAlbums);
            this.tabTousAlbums.Location = new System.Drawing.Point(4, 47);
            this.tabTousAlbums.Name = "tabTousAlbums";
            this.tabTousAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabTousAlbums.Size = new System.Drawing.Size(1091, 432);
            this.tabTousAlbums.TabIndex = 1;
            this.tabTousAlbums.Text = "Tous les albums";
            this.tabTousAlbums.UseVisualStyleBackColor = true;
            // 
            // lab_AllAlbums
            // 
            this.lab_AllAlbums.AutoSize = true;
            this.lab_AllAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_AllAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_AllAlbums.Location = new System.Drawing.Point(399, 67);
            this.lab_AllAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_AllAlbums.Name = "lab_AllAlbums";
            this.lab_AllAlbums.Size = new System.Drawing.Size(280, 39);
            this.lab_AllAlbums.TabIndex = 16;
            this.lab_AllAlbums.Text = "Tous les albums";
            // 
            // tb_Recherche
            // 
            this.tb_Recherche.Location = new System.Drawing.Point(44, 173);
            this.tb_Recherche.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Recherche.Name = "tb_Recherche";
            this.tb_Recherche.Size = new System.Drawing.Size(243, 38);
            this.tb_Recherche.TabIndex = 17;
            // 
            // comboBox_Genre
            // 
            this.comboBox_Genre.FormattingEnabled = true;
            this.comboBox_Genre.Location = new System.Drawing.Point(472, 172);
            this.comboBox_Genre.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Genre.Name = "comboBox_Genre";
            this.comboBox_Genre.Size = new System.Drawing.Size(160, 39);
            this.comboBox_Genre.TabIndex = 18;
            this.comboBox_Genre.Text = "Exemple";
            // 
            // comboBox_Catégorie
            // 
            this.comboBox_Catégorie.FormattingEnabled = true;
            this.comboBox_Catégorie.Location = new System.Drawing.Point(836, 172);
            this.comboBox_Catégorie.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Catégorie.Name = "comboBox_Catégorie";
            this.comboBox_Catégorie.Size = new System.Drawing.Size(160, 39);
            this.comboBox_Catégorie.TabIndex = 19;
            this.comboBox_Catégorie.Text = "Exemple";
            // 
            // lab_Filtrer
            // 
            this.lab_Filtrer.AutoSize = true;
            this.lab_Filtrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Filtrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Filtrer.Location = new System.Drawing.Point(39, 125);
            this.lab_Filtrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Filtrer.Name = "lab_Filtrer";
            this.lab_Filtrer.Size = new System.Drawing.Size(115, 25);
            this.lab_Filtrer.TabIndex = 20;
            this.lab_Filtrer.Text = "Recherche";
            // 
            // lab_SearchGenre
            // 
            this.lab_SearchGenre.AutoSize = true;
            this.lab_SearchGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SearchGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_SearchGenre.Location = new System.Drawing.Point(468, 147);
            this.lab_SearchGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_SearchGenre.Name = "lab_SearchGenre";
            this.lab_SearchGenre.Size = new System.Drawing.Size(172, 20);
            this.lab_SearchGenre.TabIndex = 21;
            this.lab_SearchGenre.Text = "Sélectionner un genre";
            // 
            // lab_SearchCategorie
            // 
            this.lab_SearchCategorie.AutoSize = true;
            this.lab_SearchCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SearchCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_SearchCategorie.Location = new System.Drawing.Point(832, 147);
            this.lab_SearchCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_SearchCategorie.Name = "lab_SearchCategorie";
            this.lab_SearchCategorie.Size = new System.Drawing.Size(208, 20);
            this.lab_SearchCategorie.TabIndex = 22;
            this.lab_SearchCategorie.Text = "Sélectionner une catégorie";
            // 
            // lab_SearchKeyWord
            // 
            this.lab_SearchKeyWord.AutoSize = true;
            this.lab_SearchKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SearchKeyWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_SearchKeyWord.Location = new System.Drawing.Point(40, 150);
            this.lab_SearchKeyWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_SearchKeyWord.Name = "lab_SearchKeyWord";
            this.lab_SearchKeyWord.Size = new System.Drawing.Size(191, 20);
            this.lab_SearchKeyWord.TabIndex = 23;
            this.lab_SearchKeyWord.Text = "Sélectionner par mot clé";
            // 
            // tabAccueil
            // 
            this.tabAccueil.BackColor = System.Drawing.Color.Transparent;
            this.tabAccueil.Controls.Add(this.lab_Wishlist);
            this.tabAccueil.Controls.Add(this.lab_MyAlbums);
            this.tabAccueil.Controls.Add(this.lab_ADecouvrir);
            this.tabAccueil.Controls.Add(this.lab_Accueil);
            this.tabAccueil.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabAccueil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabAccueil.Location = new System.Drawing.Point(4, 47);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccueil.Size = new System.Drawing.Size(1091, 432);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            // 
            // lab_Accueil
            // 
            this.lab_Accueil.AutoSize = true;
            this.lab_Accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Accueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Accueil.Location = new System.Drawing.Point(477, 29);
            this.lab_Accueil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Accueil.Name = "lab_Accueil";
            this.lab_Accueil.Size = new System.Drawing.Size(135, 39);
            this.lab_Accueil.TabIndex = 9;
            this.lab_Accueil.Text = "Accueil";
            // 
            // lab_ADecouvrir
            // 
            this.lab_ADecouvrir.AutoSize = true;
            this.lab_ADecouvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ADecouvrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_ADecouvrir.Location = new System.Drawing.Point(29, 88);
            this.lab_ADecouvrir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_ADecouvrir.Name = "lab_ADecouvrir";
            this.lab_ADecouvrir.Size = new System.Drawing.Size(152, 29);
            this.lab_ADecouvrir.TabIndex = 10;
            this.lab_ADecouvrir.Text = "A découvrir";
            // 
            // lab_MyAlbums
            // 
            this.lab_MyAlbums.AutoSize = true;
            this.lab_MyAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MyAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_MyAlbums.Location = new System.Drawing.Point(28, 241);
            this.lab_MyAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_MyAlbums.Name = "lab_MyAlbums";
            this.lab_MyAlbums.Size = new System.Drawing.Size(161, 29);
            this.lab_MyAlbums.TabIndex = 11;
            this.lab_MyAlbums.Text = "Mes albums";
            // 
            // lab_Wishlist
            // 
            this.lab_Wishlist.AutoSize = true;
            this.lab_Wishlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Wishlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Wishlist.Location = new System.Drawing.Point(29, 370);
            this.lab_Wishlist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Wishlist.Name = "lab_Wishlist";
            this.lab_Wishlist.Size = new System.Drawing.Size(149, 29);
            this.lab_Wishlist.TabIndex = 12;
            this.lab_Wishlist.Text = "Ma wishlist";
            // 
            // tabMenu
            // 
            this.tabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMenu.Controls.Add(this.tabAccueil);
            this.tabMenu.Controls.Add(this.tabTousAlbums);
            this.tabMenu.Controls.Add(this.tabMesAlbums);
            this.tabMenu.Controls.Add(this.tabWishlist);
            this.tabMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.HotTrack = true;
            this.tabMenu.Location = new System.Drawing.Point(0, 89);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Drawing.Point(32, 5);
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1099, 483);
            this.tabMenu.TabIndex = 0;
            // 
            // link_Deconnexion
            // 
            this.link_Deconnexion.ActiveLinkColor = System.Drawing.Color.White;
            this.link_Deconnexion.AutoSize = true;
            this.link_Deconnexion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.link_Deconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Deconnexion.LinkColor = System.Drawing.Color.White;
            this.link_Deconnexion.Location = new System.Drawing.Point(956, 56);
            this.link_Deconnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_Deconnexion.Name = "link_Deconnexion";
            this.link_Deconnexion.Size = new System.Drawing.Size(139, 26);
            this.link_Deconnexion.TabIndex = 8;
            this.link_Deconnexion.TabStop = true;
            this.link_Deconnexion.Text = "Déconnexion";
            this.link_Deconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_Deconnexion.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(0, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1099, 38);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lab_nom_utilisateur
            // 
            this.lab_nom_utilisateur.AutoSize = true;
            this.lab_nom_utilisateur.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lab_nom_utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nom_utilisateur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_nom_utilisateur.Location = new System.Drawing.Point(127, 56);
            this.lab_nom_utilisateur.Name = "lab_nom_utilisateur";
            this.lab_nom_utilisateur.Size = new System.Drawing.Size(66, 26);
            this.lab_nom_utilisateur.TabIndex = 10;
            this.lab_nom_utilisateur.Text = "user1";
            // 
            // lab_utilisateur
            // 
            this.lab_utilisateur.AutoSize = true;
            this.lab_utilisateur.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lab_utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_utilisateur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_utilisateur.Location = new System.Drawing.Point(12, 56);
            this.lab_utilisateur.Name = "lab_utilisateur";
            this.lab_utilisateur.Size = new System.Drawing.Size(121, 26);
            this.lab_utilisateur.TabIndex = 11;
            this.lab_utilisateur.Text = "Utilisateur :";
            // 
            // BDliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 571);
            this.Controls.Add(this.lab_utilisateur);
            this.Controls.Add(this.lab_nom_utilisateur);
            this.Controls.Add(this.link_Deconnexion);
            this.Controls.Add(this.Tb_Titre);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.textBox1);
            this.Name = "BDliotheque";
            this.Text = "BD\'liotheque";
            this.tabWishlist.ResumeLayout(false);
            this.tabWishlist.PerformLayout();
            this.tabMesAlbums.ResumeLayout(false);
            this.tabMesAlbums.PerformLayout();
            this.tabTousAlbums.ResumeLayout(false);
            this.tabTousAlbums.PerformLayout();
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tb_Titre;
        private System.Windows.Forms.TabPage tabWishlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabMesAlbums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabTousAlbums;
        private System.Windows.Forms.Label lab_SearchKeyWord;
        private System.Windows.Forms.Label lab_SearchCategorie;
        private System.Windows.Forms.Label lab_SearchGenre;
        private System.Windows.Forms.Label lab_Filtrer;
        private System.Windows.Forms.ComboBox comboBox_Catégorie;
        private System.Windows.Forms.ComboBox comboBox_Genre;
        private System.Windows.Forms.TextBox tb_Recherche;
        private System.Windows.Forms.Label lab_AllAlbums;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.Label lab_Wishlist;
        private System.Windows.Forms.Label lab_MyAlbums;
        private System.Windows.Forms.Label lab_ADecouvrir;
        private System.Windows.Forms.Label lab_Accueil;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.LinkLabel link_Deconnexion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lab_nom_utilisateur;
        private System.Windows.Forms.Label lab_utilisateur;
    }
}