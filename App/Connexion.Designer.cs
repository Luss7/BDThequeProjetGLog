namespace App
{
    partial class Connexion
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
            this.lab_Connexion = new System.Windows.Forms.Label();
            this.lab_Login = new System.Windows.Forms.Label();
            this.lab_Mdp = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Mdp = new System.Windows.Forms.TextBox();
            this.btn_ValiderConnexion = new System.Windows.Forms.Button();
            this.Tb_Titre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_Connexion
            // 
            this.lab_Connexion.AutoSize = true;
            this.lab_Connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Connexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Connexion.Location = new System.Drawing.Point(440, 84);
            this.lab_Connexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Connexion.Name = "lab_Connexion";
            this.lab_Connexion.Size = new System.Drawing.Size(190, 39);
            this.lab_Connexion.TabIndex = 1;
            this.lab_Connexion.Text = "Connexion";
            // 
            // lab_Login
            // 
            this.lab_Login.AutoSize = true;
            this.lab_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Login.Location = new System.Drawing.Point(492, 185);
            this.lab_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Login.Name = "lab_Login";
            this.lab_Login.Size = new System.Drawing.Size(80, 31);
            this.lab_Login.TabIndex = 2;
            this.lab_Login.Text = "Login";
            // 
            // lab_Mdp
            // 
            this.lab_Mdp.AutoSize = true;
            this.lab_Mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Mdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_Mdp.Location = new System.Drawing.Point(455, 307);
            this.lab_Mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Mdp.Name = "lab_Mdp";
            this.lab_Mdp.Size = new System.Drawing.Size(176, 31);
            this.lab_Mdp.TabIndex = 3;
            this.lab_Mdp.Text = "Mot de passe";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(383, 234);
            this.tb_Login.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(309, 22);
            this.tb_Login.TabIndex = 4;
            this.tb_Login.TextChanged += new System.EventHandler(this.tb_Login_TextChanged);
            // 
            // tb_Mdp
            // 
            this.tb_Mdp.Location = new System.Drawing.Point(383, 351);
            this.tb_Mdp.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mdp.Name = "tb_Mdp";
            this.tb_Mdp.Size = new System.Drawing.Size(309, 22);
            this.tb_Mdp.TabIndex = 5;
            // 
            // btn_ValiderConnexion
            // 
            this.btn_ValiderConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ValiderConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValiderConnexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ValiderConnexion.Location = new System.Drawing.Point(486, 412);
            this.btn_ValiderConnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ValiderConnexion.Name = "btn_ValiderConnexion";
            this.btn_ValiderConnexion.Size = new System.Drawing.Size(100, 36);
            this.btn_ValiderConnexion.TabIndex = 6;
            this.btn_ValiderConnexion.Text = "Valider";
            this.btn_ValiderConnexion.UseVisualStyleBackColor = false;
            this.btn_ValiderConnexion.Click += new System.EventHandler(this.btn_ValiderConnexion_Click);
            // 
            // Tb_Titre
            // 
            this.Tb_Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Tb_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Titre.ForeColor = System.Drawing.SystemColors.Info;
            this.Tb_Titre.Location = new System.Drawing.Point(0, 27);
            this.Tb_Titre.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Titre.Name = "Tb_Titre";
            this.Tb_Titre.Size = new System.Drawing.Size(1064, 53);
            this.Tb_Titre.TabIndex = 7;
            this.Tb_Titre.Text = "BD\'LIOTHEQUE";
            this.Tb_Titre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Tb_Titre);
            this.Controls.Add(this.btn_ValiderConnexion);
            this.Controls.Add(this.tb_Mdp);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lab_Mdp);
            this.Controls.Add(this.lab_Login);
            this.Controls.Add(this.lab_Connexion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_Connexion;
        private System.Windows.Forms.Label lab_Login;
        private System.Windows.Forms.Label lab_Mdp;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Mdp;
        private System.Windows.Forms.Button btn_ValiderConnexion;
        private System.Windows.Forms.TextBox Tb_Titre;
    }
}