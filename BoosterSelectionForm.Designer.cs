using PokemonTCG;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBooster
{
    partial class BoosterSelectionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            Label lblBoosterFeu = new Label();
            lblBoosterFeu.Location = new System.Drawing.Point(50, 10);
            lblBoosterFeu.Size = new System.Drawing.Size(200, 30);
            lblBoosterFeu.Text = "Booster Feu";
            lblBoosterFeu.TextAlign = ContentAlignment.MiddleCenter;

            Label lblBoosterEau = new Label();
            lblBoosterEau.Location = new System.Drawing.Point(300, 10);
            lblBoosterEau.Size = new System.Drawing.Size(200, 30);
            lblBoosterEau.Text = "Booster Eau";
            lblBoosterEau.TextAlign = ContentAlignment.MiddleCenter;

            Label lblBoosterElectric = new Label();
            lblBoosterElectric.Location = new System.Drawing.Point(550, 10);
            lblBoosterElectric.Size = new System.Drawing.Size(200, 30);
            lblBoosterElectric.Text = "Booster Électrique";
            lblBoosterElectric.TextAlign = ContentAlignment.MiddleCenter;

            PictureBox pbBoosterFeu = new PictureBox();
            pbBoosterFeu.Location = new System.Drawing.Point(50, 50);
            pbBoosterFeu.Size = new System.Drawing.Size(200, 200);
            pbBoosterFeu.Image = Image.FromFile("Images/Booster-Feu.jpg");
            pbBoosterFeu.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBoosterFeu.Cursor = Cursors.Hand;
            pbBoosterFeu.Click += (sender, e) => OpenMainForm(1); 

            PictureBox pbBoosterEau = new PictureBox();
            pbBoosterEau.Location = new System.Drawing.Point(300, 50);
            pbBoosterEau.Size = new System.Drawing.Size(200, 200);
            pbBoosterEau.Image = Image.FromFile("Images/Booster-Eau.jpg");
            pbBoosterEau.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBoosterEau.Cursor = Cursors.Hand;
            pbBoosterEau.Click += (sender, e) => OpenMainForm(2);

            PictureBox pbBoosterElectric = new PictureBox();
            pbBoosterElectric.Location = new System.Drawing.Point(550, 50);
            pbBoosterElectric.Size = new System.Drawing.Size(200, 200);
            pbBoosterElectric.Image = Image.FromFile("Images/Booster-Electric.jpg");
            pbBoosterElectric.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBoosterElectric.Cursor = Cursors.Hand;
            pbBoosterElectric.Click += (sender, e) => OpenMainForm(3); 

            this.Controls.Add(lblBoosterFeu);
            this.Controls.Add(lblBoosterEau);
            this.Controls.Add(lblBoosterElectric);
            this.Controls.Add(pbBoosterFeu);
            this.Controls.Add(pbBoosterEau);
            this.Controls.Add(pbBoosterElectric);

            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Text = "Choisissez un Booster";
            this.ResumeLayout(false);
        }

        private void OpenMainForm(int boosterId)
        {
            MainForm mainForm = new MainForm(boosterId);
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }
    }
}
