using System.Drawing;
using System.Windows.Forms;
using System;

namespace PokemonTCG
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.lblNomCarte = new Label();
            this.lblNomCarte.AutoSize = true;
            this.lblNomCarte.Location = new Point(10, 10);
            this.lblNomCarte.Name = "lblNomCarte";
            this.lblNomCarte.Size = new Size(200, 23);
            this.lblNomCarte.Text = "Nom de la carte";

            this.pbImageCarte = new PictureBox();
            this.pbImageCarte.Location = new Point(10, 40);
            this.pbImageCarte.Name = "pbImageCarte";
            this.pbImageCarte.Size = new Size(200, 200);
            this.pbImageCarte.TabStop = false;

            this.btnOuvrirBooster = new Button();
            this.btnOuvrirBooster.Location = new Point(10, 250);
            this.btnOuvrirBooster.Name = "btnOuvrirBooster";
            this.btnOuvrirBooster.Size = new Size(200, 30);
            this.btnOuvrirBooster.Text = "Ouvrir Booster";
            this.btnOuvrirBooster.Click += new EventHandler(this.btnOuvrirBooster_Click);

            this.Controls.Add(this.lblNomCarte);
            this.Controls.Add(this.pbImageCarte);
            this.Controls.Add(this.btnOuvrirBooster);

            this.ClientSize = new Size(542, 358);
            this.Name = "MainForm";
            this.Text = $"Booster : {boosterType}";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

