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

            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Text = "Choisissez un Booster";
            this.BackColor = Color.FromArgb(240, 240, 240); 

            Label lblBoosterFeu = new Label();
            lblBoosterFeu.Location = new System.Drawing.Point(50, 270);
            lblBoosterFeu.Size = new System.Drawing.Size(200, 30);
            lblBoosterFeu.Text = "Booster Feu";
            lblBoosterFeu.TextAlign = ContentAlignment.MiddleCenter;
            lblBoosterFeu.Font = new Font("Arial", 12, FontStyle.Bold);
            lblBoosterFeu.ForeColor = Color.FromArgb(200, 50, 50); 

            Label lblBoosterEau = new Label();
            lblBoosterEau.Location = new System.Drawing.Point(300, 270);
            lblBoosterEau.Size = new System.Drawing.Size(200, 30);
            lblBoosterEau.Text = "Booster Eau";
            lblBoosterEau.TextAlign = ContentAlignment.MiddleCenter;
            lblBoosterEau.Font = new Font("Arial", 12, FontStyle.Bold);
            lblBoosterEau.ForeColor = Color.FromArgb(50, 50, 200); 


            Label lblBoosterElectric = new Label();
            lblBoosterElectric.Location = new System.Drawing.Point(550, 270);
            lblBoosterElectric.Size = new System.Drawing.Size(200, 30);
            lblBoosterElectric.Text = "Booster Électrique";
            lblBoosterElectric.TextAlign = ContentAlignment.MiddleCenter;
            lblBoosterElectric.Font = new Font("Arial", 12, FontStyle.Bold);
            lblBoosterElectric.ForeColor = Color.FromArgb(200, 200, 50);

            PictureBox pbBoosterFeu = new PictureBox();
            pbBoosterFeu.Location = new System.Drawing.Point(50, 50);
            pbBoosterFeu.Size = new System.Drawing.Size(200, 200);
            pbBoosterFeu.Image = Image.FromFile("Images/Booster-Feu.jpg");
            pbBoosterFeu.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBoosterFeu.Cursor = Cursors.Hand;
            pbBoosterFeu.BorderStyle = BorderStyle.FixedSingle;
            pbBoosterFeu.Click += (sender, e) => OpenMainForm(1);

            PictureBox pbBoosterEau = new PictureBox();
            pbBoosterEau.Location = new System.Drawing.Point(300, 50);
            pbBoosterEau.Size = new System.Drawing.Size(200, 200);
            pbBoosterEau.Image = Image.FromFile("Images/Booster-Eau.jpg");
            pbBoosterEau.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBoosterEau.Cursor = Cursors.Hand;
            pbBoosterEau.BorderStyle = BorderStyle.FixedSingle;
            pbBoosterEau.Click += (sender, e) => OpenMainForm(2);

            PictureBox pbBoosterElectric = new PictureBox();
            pbBoosterElectric.Location = new System.Drawing.Point(550, 50);
            pbBoosterElectric.Size = new System.Drawing.Size(200, 200);
            pbBoosterElectric.Image = Image.FromFile("Images/Booster-Electric.jpg");
            pbBoosterElectric.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBoosterElectric.Cursor = Cursors.Hand;
            pbBoosterElectric.BorderStyle = BorderStyle.FixedSingle;
            pbBoosterElectric.Click += (sender, e) => OpenMainForm(3);

            this.Controls.Add(lblBoosterFeu);
            this.Controls.Add(lblBoosterEau);
            this.Controls.Add(lblBoosterElectric);
            this.Controls.Add(pbBoosterFeu);
            this.Controls.Add(pbBoosterEau);
            this.Controls.Add(pbBoosterElectric);

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
