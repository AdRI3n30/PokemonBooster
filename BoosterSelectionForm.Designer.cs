using PokemonTCG;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBooster
{
    partial class BoosterSelectionForm
    {
        private System.ComponentModel.IContainer components = null;

        // Méthode pour libérer les ressources lorsque le formulaire est fermé
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();  
            }
            base.Dispose(disposing);  
        }

        // Initialisation des composants du formulaire
        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(800, 400);  
            this.Text = "Choisissez un Booster"; 
            this.BackColor = Color.FromArgb(240, 240, 240);  

            // Labels pour afficher les noms des boosters
            Label lblBoosterFeu = new Label();
            lblBoosterFeu.Location = new System.Drawing.Point(50, 270);  
            lblBoosterFeu.Size = new System.Drawing.Size(200, 30);  
            lblBoosterFeu.Text = "Booster Gold";  
            lblBoosterFeu.TextAlign = ContentAlignment.MiddleCenter;  
            lblBoosterFeu.Font = new Font("Arial", 12, FontStyle.Bold);  
            lblBoosterFeu.ForeColor = Color.FromArgb(200, 50, 50);  

            // Labels pour les autres boosters (argent et bronze)
            Label lblBoosterEau = new Label();
            lblBoosterEau.Location = new System.Drawing.Point(300, 270);
            lblBoosterEau.Size = new System.Drawing.Size(200, 30);
            lblBoosterEau.Text = "Booster Argent";
            lblBoosterEau.TextAlign = ContentAlignment.MiddleCenter;
            lblBoosterEau.Font = new Font("Arial", 12, FontStyle.Bold);
            lblBoosterEau.ForeColor = Color.FromArgb(50, 50, 200);

            Label lblBoosterElectric = new Label();
            lblBoosterElectric.Location = new System.Drawing.Point(550, 270);
            lblBoosterElectric.Size = new System.Drawing.Size(200, 30);
            lblBoosterElectric.Text = "Booster Bronze";
            lblBoosterElectric.TextAlign = ContentAlignment.MiddleCenter;
            lblBoosterElectric.Font = new Font("Arial", 12, FontStyle.Bold);
            lblBoosterElectric.ForeColor = Color.FromArgb(200, 200, 50);

            // Images des boosters dans des PictureBox
            PictureBox pbBoosterFeu = new PictureBox();
            pbBoosterFeu.Location = new System.Drawing.Point(50, 50);
            pbBoosterFeu.Size = new System.Drawing.Size(200, 200);
            pbBoosterFeu.Image = Image.FromFile("Images/Booster-Feu.jpg");  
            pbBoosterFeu.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBoosterFeu.Cursor = Cursors.Hand;  
            pbBoosterFeu.BorderStyle = BorderStyle.FixedSingle;
            pbBoosterFeu.Click += (sender, e) => OpenMainForm(1);  // Ouvre le formulaire principal pour le booster Gold

            PictureBox pbBoosterEau = new PictureBox();
            pbBoosterEau.Location = new System.Drawing.Point(300, 50);
            pbBoosterEau.Size = new System.Drawing.Size(200, 200);
            pbBoosterEau.Image = Image.FromFile("Images/Booster-Eau.jpg");
            pbBoosterEau.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBoosterEau.Cursor = Cursors.Hand;
            pbBoosterEau.BorderStyle = BorderStyle.FixedSingle;
            pbBoosterEau.Click += (sender, e) => OpenMainForm(2);  // Ouvre le formulaire pour le booster Argent

            PictureBox pbBoosterElectric = new PictureBox();
            pbBoosterElectric.Location = new System.Drawing.Point(550, 50);
            pbBoosterElectric.Size = new System.Drawing.Size(200, 200);
            pbBoosterElectric.Image = Image.FromFile("Images/Booster-Electric.jpg");
            pbBoosterElectric.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBoosterElectric.Cursor = Cursors.Hand;
            pbBoosterElectric.BorderStyle = BorderStyle.FixedSingle;
            pbBoosterElectric.Click += (sender, e) => OpenMainForm(3);  // Ouvre le formulaire pour le booster Bronze

            // Bouton "Retour" pour revenir à la fenêtre précédente
            Button btnBack = new Button();
            btnBack.Text = "Retour";
            btnBack.Location = new System.Drawing.Point(20, 330);
            btnBack.Size = new System.Drawing.Size(100, 40);
            btnBack.Font = new Font("Arial", 10, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(200, 50, 50);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += BtnBack_Click;  // Action à effectuer lors du clic (fermer le formulaire actuel)

            // Bouton "Info" pour afficher des informations sur les boosters
            Button btnInfo = new Button();
            btnInfo.Text = "Info";
            btnInfo.Location = new System.Drawing.Point(650, 330);
            btnInfo.Size = new System.Drawing.Size(100, 40);
            btnInfo.Font = new Font("Arial", 10, FontStyle.Bold);
            btnInfo.BackColor = Color.FromArgb(100, 100, 255);
            btnInfo.ForeColor = Color.White;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.Cursor = Cursors.Hand;
            btnInfo.Click += BtnInfo_Click;  // Afficher des informations supplémentaires sur les boosters

            // Ajout de tous les contrôles dans le formulaire
            this.Controls.Add(lblBoosterFeu);
            this.Controls.Add(lblBoosterEau);
            this.Controls.Add(lblBoosterElectric);
            this.Controls.Add(pbBoosterFeu);
            this.Controls.Add(pbBoosterEau);
            this.Controls.Add(pbBoosterElectric);
            this.Controls.Add(btnBack);
            this.Controls.Add(btnInfo);

            this.ResumeLayout(false);
        }

        // Méthode pour ouvrir le formulaire principal avec le booster sélectionné
        private void OpenMainForm(int boosterId)
        {
            MainForm mainForm = new MainForm(boosterId);
            this.Hide();  
            mainForm.ShowDialog(); 
            this.Show();  
        }

        // Méthode pour gérer le clic sur le bouton "Retour"
        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();  
            this.Close();  
        }

        // Méthode pour afficher des informations sur les boosters
        private void BtnInfo_Click(object sender, System.EventArgs e)
        {
            // Affichage des informations sur les boosters disponibles
            string infoMessage = "Voici les trois boosters disponibles :\n\n" +
                                 "1. Booster Gold : Contient des cartes avec une rareté élevée.\n" +
                                 "2. Booster Argent : Contient des cartes avec une rareté modérée.\n" +
                                 "3. Booster Bronze : Contient des cartes avec une rareté plus faible.\n\n" +
                                 "Choisissez un booster et commencez votre aventure !";

            // Affiche les informations dans une boîte de message
            MessageBox.Show(infoMessage, "Informations sur les Boosters", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
