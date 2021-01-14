namespace App
{
    partial class AllAlbums
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
            this.flowLayoutPanel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Accueil = new System.Windows.Forms.Button();
            this.btn_AllAlbums = new System.Windows.Forms.Button();
            this.btn_MyAlbums = new System.Windows.Forms.Button();
            this.btn_Wishlist = new System.Windows.Forms.Button();
            this.link_Deconnexion = new System.Windows.Forms.LinkLabel();
            this.lab_AllAlbums = new System.Windows.Forms.Label();
            this.Tb_Titre = new System.Windows.Forms.TextBox();
            this.tb_Recherche = new System.Windows.Forms.TextBox();
            this.comboBox_Genre = new System.Windows.Forms.ComboBox();
            this.comboBox_Catégorie = new System.Windows.Forms.ComboBox();
            this.lab_Filtrer = new System.Windows.Forms.Label();
            this.lab_SearchGenre = new System.Windows.Forms.Label();
            this.lab_SearchCategorie = new System.Windows.Forms.Label();
            this.lab_SearchKeyWord = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Menu
            // 
            this.flowLayoutPanel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel_Menu.Controls.Add(this.btn_Accueil);
            this.flowLayoutPanel_Menu.Controls.Add(this.btn_AllAlbums);
            this.flowLayoutPanel_Menu.Controls.Add(this.btn_MyAlbums);
            this.flowLayoutPanel_Menu.Controls.Add(this.btn_Wishlist);
            this.flowLayoutPanel_Menu.Controls.Add(this.link_Deconnexion);
            this.flowLayoutPanel_Menu.Location = new System.Drawing.Point(0, 62);
            this.flowLayoutPanel_Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel_Menu.Name = "flowLayoutPanel_Menu";
            this.flowLayoutPanel_Menu.Size = new System.Drawing.Size(1065, 53);
            this.flowLayoutPanel_Menu.TabIndex = 8;
            // 
            // btn_Accueil
            // 
            this.btn_Accueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accueil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Accueil.Location = new System.Drawing.Point(4, 4);
            this.btn_Accueil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Accueil.Name = "btn_Accueil";
            this.btn_Accueil.Size = new System.Drawing.Size(149, 46);
            this.btn_Accueil.TabIndex = 6;
            this.btn_Accueil.Text = "Accueil";
            this.btn_Accueil.UseVisualStyleBackColor = false;
            this.btn_Accueil.Click += new System.EventHandler(this.btn_Accueil_Click);
            // 
            // btn_AllAlbums
            // 
            this.btn_AllAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AllAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllAlbums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AllAlbums.Location = new System.Drawing.Point(161, 4);
            this.btn_AllAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AllAlbums.Name = "btn_AllAlbums";
            this.btn_AllAlbums.Size = new System.Drawing.Size(260, 46);
            this.btn_AllAlbums.TabIndex = 7;
            this.btn_AllAlbums.Text = "Tous les albums";
            this.btn_AllAlbums.UseVisualStyleBackColor = false;
            this.btn_AllAlbums.Click += new System.EventHandler(this.btn_AllAlbums_Click);
            // 
            // btn_MyAlbums
            // 
            this.btn_MyAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_MyAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MyAlbums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MyAlbums.Location = new System.Drawing.Point(429, 4);
            this.btn_MyAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_MyAlbums.Name = "btn_MyAlbums";
            this.btn_MyAlbums.Size = new System.Drawing.Size(208, 46);
            this.btn_MyAlbums.TabIndex = 8;
            this.btn_MyAlbums.Text = "Mes albums";
            this.btn_MyAlbums.UseVisualStyleBackColor = false;
            this.btn_MyAlbums.Click += new System.EventHandler(this.btn_MyAlbums_Click);
            // 
            // btn_Wishlist
            // 
            this.btn_Wishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Wishlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Wishlist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Wishlist.Location = new System.Drawing.Point(645, 4);
            this.btn_Wishlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Wishlist.Name = "btn_Wishlist";
            this.btn_Wishlist.Size = new System.Drawing.Size(208, 46);
            this.btn_Wishlist.TabIndex = 9;
            this.btn_Wishlist.Text = "Ma wihslist";
            this.btn_Wishlist.UseVisualStyleBackColor = false;
            this.btn_Wishlist.Click += new System.EventHandler(this.btn_Wishlist_Click);
            // 
            // link_Deconnexion
            // 
            this.link_Deconnexion.ActiveLinkColor = System.Drawing.Color.White;
            this.link_Deconnexion.AutoSize = true;
            this.link_Deconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Deconnexion.LinkColor = System.Drawing.Color.White;
            this.link_Deconnexion.Location = new System.Drawing.Point(861, 0);
            this.link_Deconnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_Deconnexion.Name = "link_Deconnexion";
            this.link_Deconnexion.Size = new System.Drawing.Size(172, 31);
            this.link_Deconnexion.TabIndex = 6;
            this.link_Deconnexion.TabStop = true;
            this.link_Deconnexion.Text = "Déconnexion";
            this.link_Deconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_Deconnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Deconnexion_LinkClicked);
            // 
            // lab_AllAlbums
            // 
            this.lab_AllAlbums.AutoSize = true;
            this.lab_AllAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_AllAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_AllAlbums.Location = new System.Drawing.Point(376, 139);
            this.lab_AllAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_AllAlbums.Name = "lab_AllAlbums";
            this.lab_AllAlbums.Size = new System.Drawing.Size(280, 39);
            this.lab_AllAlbums.TabIndex = 7;
            this.lab_AllAlbums.Text = "Tous les albums";
            // 
            // Tb_Titre
            // 
            this.Tb_Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Tb_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Titre.ForeColor = System.Drawing.SystemColors.Info;
            this.Tb_Titre.Location = new System.Drawing.Point(0, 10);
            this.Tb_Titre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Titre.Name = "Tb_Titre";
            this.Tb_Titre.Size = new System.Drawing.Size(1064, 53);
            this.Tb_Titre.TabIndex = 6;
            this.Tb_Titre.Text = "BD\'LIOTHEQUE";
            this.Tb_Titre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Recherche
            // 
            this.tb_Recherche.Location = new System.Drawing.Point(21, 245);
            this.tb_Recherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Recherche.Name = "tb_Recherche";
            this.tb_Recherche.Size = new System.Drawing.Size(243, 22);
            this.tb_Recherche.TabIndex = 9;
            this.tb_Recherche.TextChanged += new System.EventHandler(this.tb_Recherche_TextChanged);
            // 
            // comboBox_Genre
            // 
            this.comboBox_Genre.FormattingEnabled = true;
            this.comboBox_Genre.Location = new System.Drawing.Point(449, 244);
            this.comboBox_Genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Genre.Name = "comboBox_Genre";
            this.comboBox_Genre.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Genre.TabIndex = 10;
            this.comboBox_Genre.Text = "Exemple";
            this.comboBox_Genre.SelectedIndexChanged += new System.EventHandler(this.comboBox_Genre_SelectedIndexChanged);
            // 
            // comboBox_Catégorie
            // 
            this.comboBox_Catégorie.FormattingEnabled = true;
            this.comboBox_Catégorie.Location = new System.Drawing.Point(813, 244);
            this.comboBox_Catégorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Catégorie.Name = "comboBox_Catégorie";
            this.comboBox_Catégorie.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Catégorie.TabIndex = 11;
            this.comboBox_Catégorie.Text = "Exemple";
            this.comboBox_Catégorie.SelectedIndexChanged += new System.EventHandler(this.comboBox_Catégorie_SelectedIndexChanged);
            // 
            // lab_Filtrer
            // 
            this.lab_Filtrer.AutoSize = true;
            this.lab_Filtrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Filtrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Filtrer.Location = new System.Drawing.Point(16, 197);
            this.lab_Filtrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Filtrer.Name = "lab_Filtrer";
            this.lab_Filtrer.Size = new System.Drawing.Size(115, 25);
            this.lab_Filtrer.TabIndex = 12;
            this.lab_Filtrer.Text = "Recherche";
            // 
            // lab_SearchGenre
            // 
            this.lab_SearchGenre.AutoSize = true;
            this.lab_SearchGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SearchGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_SearchGenre.Location = new System.Drawing.Point(445, 219);
            this.lab_SearchGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_SearchGenre.Name = "lab_SearchGenre";
            this.lab_SearchGenre.Size = new System.Drawing.Size(172, 20);
            this.lab_SearchGenre.TabIndex = 13;
            this.lab_SearchGenre.Text = "Sélectionner un genre";
            // 
            // lab_SearchCategorie
            // 
            this.lab_SearchCategorie.AutoSize = true;
            this.lab_SearchCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SearchCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_SearchCategorie.Location = new System.Drawing.Point(809, 219);
            this.lab_SearchCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_SearchCategorie.Name = "lab_SearchCategorie";
            this.lab_SearchCategorie.Size = new System.Drawing.Size(208, 20);
            this.lab_SearchCategorie.TabIndex = 14;
            this.lab_SearchCategorie.Text = "Sélectionner une catégorie";
            // 
            // lab_SearchKeyWord
            // 
            this.lab_SearchKeyWord.AutoSize = true;
            this.lab_SearchKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SearchKeyWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_SearchKeyWord.Location = new System.Drawing.Point(17, 222);
            this.lab_SearchKeyWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_SearchKeyWord.Name = "lab_SearchKeyWord";
            this.lab_SearchKeyWord.Size = new System.Drawing.Size(191, 20);
            this.lab_SearchKeyWord.TabIndex = 15;
            this.lab_SearchKeyWord.Text = "Sélectionner par mot clé";
            // 
            // AllAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lab_SearchKeyWord);
            this.Controls.Add(this.lab_SearchCategorie);
            this.Controls.Add(this.lab_SearchGenre);
            this.Controls.Add(this.lab_Filtrer);
            this.Controls.Add(this.comboBox_Catégorie);
            this.Controls.Add(this.comboBox_Genre);
            this.Controls.Add(this.tb_Recherche);
            this.Controls.Add(this.flowLayoutPanel_Menu);
            this.Controls.Add(this.lab_AllAlbums);
            this.Controls.Add(this.Tb_Titre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AllAlbums";
            this.Text = "AllAlbums";
            this.flowLayoutPanel_Menu.ResumeLayout(false);
            this.flowLayoutPanel_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Menu;
        private System.Windows.Forms.Button btn_Accueil;
        private System.Windows.Forms.Button btn_AllAlbums;
        private System.Windows.Forms.Button btn_MyAlbums;
        private System.Windows.Forms.Button btn_Wishlist;
        private System.Windows.Forms.LinkLabel link_Deconnexion;
        private System.Windows.Forms.Label lab_AllAlbums;
        private System.Windows.Forms.TextBox Tb_Titre;
        private System.Windows.Forms.TextBox tb_Recherche;
        private System.Windows.Forms.ComboBox comboBox_Genre;
        private System.Windows.Forms.ComboBox comboBox_Catégorie;
        private System.Windows.Forms.Label lab_Filtrer;
        private System.Windows.Forms.Label lab_SearchGenre;
        private System.Windows.Forms.Label lab_SearchCategorie;
        private System.Windows.Forms.Label lab_SearchKeyWord;
    }
}