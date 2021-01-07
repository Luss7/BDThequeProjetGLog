namespace App
{
    partial class Accueil
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
            this.lab_Accueil = new System.Windows.Forms.Label();
            this.Tb_Titre = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Accueil = new System.Windows.Forms.Button();
            this.btn_AllAlbums = new System.Windows.Forms.Button();
            this.btn_MyAlbums = new System.Windows.Forms.Button();
            this.btn_Wishlist = new System.Windows.Forms.Button();
            this.link_Deconnexion = new System.Windows.Forms.LinkLabel();
            this.lab_ADecouvrir = new System.Windows.Forms.Label();
            this.lab_MyAlbums = new System.Windows.Forms.Label();
            this.lab_Wishlist = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_Accueil
            // 
            this.lab_Accueil.AutoSize = true;
            this.lab_Accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Accueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Accueil.Location = new System.Drawing.Point(349, 114);
            this.lab_Accueil.Name = "lab_Accueil";
            this.lab_Accueil.Size = new System.Drawing.Size(109, 31);
            this.lab_Accueil.TabIndex = 3;
            this.lab_Accueil.Text = "Accueil";
            // 
            // Tb_Titre
            // 
            this.Tb_Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Tb_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Titre.ForeColor = System.Drawing.SystemColors.Info;
            this.Tb_Titre.Location = new System.Drawing.Point(0, 9);
            this.Tb_Titre.Name = "Tb_Titre";
            this.Tb_Titre.Size = new System.Drawing.Size(799, 44);
            this.Tb_Titre.TabIndex = 2;
            this.Tb_Titre.Text = "BD\'LIOTHEQUE";
            this.Tb_Titre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel_Menu
            // 
            this.flowLayoutPanel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel_Menu.Controls.Add(this.btn_Accueil);
            this.flowLayoutPanel_Menu.Controls.Add(this.btn_AllAlbums);
            this.flowLayoutPanel_Menu.Controls.Add(this.btn_MyAlbums);
            this.flowLayoutPanel_Menu.Controls.Add(this.btn_Wishlist);
            this.flowLayoutPanel_Menu.Controls.Add(this.link_Deconnexion);
            this.flowLayoutPanel_Menu.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanel_Menu.Name = "flowLayoutPanel_Menu";
            this.flowLayoutPanel_Menu.Size = new System.Drawing.Size(799, 43);
            this.flowLayoutPanel_Menu.TabIndex = 5;
            // 
            // btn_Accueil
            // 
            this.btn_Accueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accueil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Accueil.Location = new System.Drawing.Point(3, 3);
            this.btn_Accueil.Name = "btn_Accueil";
            this.btn_Accueil.Size = new System.Drawing.Size(112, 37);
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
            this.btn_AllAlbums.Location = new System.Drawing.Point(121, 3);
            this.btn_AllAlbums.Name = "btn_AllAlbums";
            this.btn_AllAlbums.Size = new System.Drawing.Size(195, 37);
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
            this.btn_MyAlbums.Location = new System.Drawing.Point(322, 3);
            this.btn_MyAlbums.Name = "btn_MyAlbums";
            this.btn_MyAlbums.Size = new System.Drawing.Size(156, 37);
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
            this.btn_Wishlist.Location = new System.Drawing.Point(484, 3);
            this.btn_Wishlist.Name = "btn_Wishlist";
            this.btn_Wishlist.Size = new System.Drawing.Size(156, 37);
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
            this.link_Deconnexion.Location = new System.Drawing.Point(646, 0);
            this.link_Deconnexion.Name = "link_Deconnexion";
            this.link_Deconnexion.Size = new System.Drawing.Size(139, 26);
            this.link_Deconnexion.TabIndex = 6;
            this.link_Deconnexion.TabStop = true;
            this.link_Deconnexion.Text = "Déconnexion";
            this.link_Deconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_Deconnexion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Deconnexion_LinkClicked);
            // 
            // lab_ADecouvrir
            // 
            this.lab_ADecouvrir.AutoSize = true;
            this.lab_ADecouvrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ADecouvrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_ADecouvrir.Location = new System.Drawing.Point(13, 162);
            this.lab_ADecouvrir.Name = "lab_ADecouvrir";
            this.lab_ADecouvrir.Size = new System.Drawing.Size(122, 25);
            this.lab_ADecouvrir.TabIndex = 6;
            this.lab_ADecouvrir.Text = "A découvrir";
            // 
            // lab_MyAlbums
            // 
            this.lab_MyAlbums.AutoSize = true;
            this.lab_MyAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MyAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_MyAlbums.Location = new System.Drawing.Point(12, 286);
            this.lab_MyAlbums.Name = "lab_MyAlbums";
            this.lab_MyAlbums.Size = new System.Drawing.Size(128, 25);
            this.lab_MyAlbums.TabIndex = 7;
            this.lab_MyAlbums.Text = "Mes albums";
            // 
            // lab_Wishlist
            // 
            this.lab_Wishlist.AutoSize = true;
            this.lab_Wishlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Wishlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Wishlist.Location = new System.Drawing.Point(13, 391);
            this.lab_Wishlist.Name = "lab_Wishlist";
            this.lab_Wishlist.Size = new System.Drawing.Size(118, 25);
            this.lab_Wishlist.TabIndex = 8;
            this.lab_Wishlist.Text = "Ma wishlist";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_Wishlist);
            this.Controls.Add(this.lab_MyAlbums);
            this.Controls.Add(this.lab_ADecouvrir);
            this.Controls.Add(this.flowLayoutPanel_Menu);
            this.Controls.Add(this.lab_Accueil);
            this.Controls.Add(this.Tb_Titre);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.flowLayoutPanel_Menu.ResumeLayout(false);
            this.flowLayoutPanel_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Accueil;
        private System.Windows.Forms.TextBox Tb_Titre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Menu;
        private System.Windows.Forms.Button btn_Accueil;
        private System.Windows.Forms.Button btn_AllAlbums;
        private System.Windows.Forms.Button btn_MyAlbums;
        private System.Windows.Forms.Button btn_Wishlist;
        private System.Windows.Forms.LinkLabel link_Deconnexion;
        private System.Windows.Forms.Label lab_ADecouvrir;
        private System.Windows.Forms.Label lab_MyAlbums;
        private System.Windows.Forms.Label lab_Wishlist;
    }
}