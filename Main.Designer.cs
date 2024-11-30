using System.Drawing;
using System.Windows.Forms;
using System;

namespace PokemonTCG
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (pbImageCarte.Image != null)
            {
                pbImageCarte.Image.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form
        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.lblNomCarte = new Label();
            this.lblNomCarte.AutoSize = true;
            this.lblNomCarte.Location = new Point(10, 10);
            this.lblNomCarte.Name = "lblNomCarte";
            this.lblNomCarte.Size = new Size(300, 23);
            this.lblNomCarte.Font = new Font("Arial", 10, FontStyle.Bold);
            this.lblNomCarte.Text = "Nom de la carte";

            this.pbImageCarte = new PictureBox();
            this.pbImageCarte.Location = new Point(10, 40);
            this.pbImageCarte.Name = "pbImageCarte";
            this.pbImageCarte.Size = new Size(250, 250);
            this.pbImageCarte.BorderStyle = BorderStyle.FixedSingle;
            this.pbImageCarte.SizeMode = PictureBoxSizeMode.CenterImage; 

            this.btnOuvrirBooster = new Button();
            this.btnOuvrirBooster.Location = new Point(10, 300);
            this.btnOuvrirBooster.Name = "btnOuvrirBooster";
            this.btnOuvrirBooster.Size = new Size(250, 40); 
            this.btnOuvrirBooster.Text = "Ouvrir Booster";
            this.btnOuvrirBooster.Font = new Font("Arial", 10, FontStyle.Regular);
            this.btnOuvrirBooster.Click += new EventHandler(this.btnOuvrirBooster_Click);

            this.Controls.Add(this.lblNomCarte);
            this.Controls.Add(this.pbImageCarte);
            this.Controls.Add(this.btnOuvrirBooster);

         
            this.ClientSize = new Size(400, 400); 
            this.Name = "MainForm";
            this.Text = "Pokemon TCG - Booster";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false; 

            this.ResumeLayout(false);
        }
        #endregion
    }
}
