using System;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonBooster
{
    public class StartForm : Form
    {
        private Button btnBooster;
        private Button btnCollection;
        private Button btnPvp;
        private Button btnResetCollection; 
        private Label lblTitle;

        public StartForm()
        {
            InitializeComponent();
        }

        // Initialisation des composants du formulaire
        private void InitializeComponent()
        {
            this.Text = "Accueil Pokémon TCG";
            this.Size = new Size(500, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 240, 255);

            lblTitle = new Label
            {
                Text = "Bienvenue dans Pokemon TCG",
                Font = new Font("Arial", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(50, 50, 100),
                Size = new Size(400, 50),
                Location = new Point(50, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnBooster = new Button
            {
                Text = "Ouvrir un Booster",
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(100, 180, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(200, 50),
                Location = new Point(150, 120),
                Cursor = Cursors.Hand
            };
            btnBooster.FlatAppearance.BorderSize = 0;
            btnBooster.Click += BtnBooster_Click;

            btnCollection = new Button
            {
                Text = "Voir la Collection",
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(100, 255, 180),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(200, 50),
                Location = new Point(150, 200),
                Cursor = Cursors.Hand
            };
            btnCollection.FlatAppearance.BorderSize = 0;
            btnCollection.Click += BtnCollection_Click;

            btnPvp = new Button
            {
                Text = "Mode PVP (À venir)",
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(138, 43, 226),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(200, 50),
                Location = new Point(150, 280),
                Cursor = Cursors.Hand,
            };
            btnPvp.FlatAppearance.BorderSize = 0;
            btnPvp.Click += BtnPvp_Click;

            // Ajouter le bouton Réinitialiser la collection
            btnResetCollection = new Button
            {
                Text = "Réinitialiser la collection",
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 100, 100),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(200, 50),
                Location = new Point(150, 360),
                Cursor = Cursors.Hand,
            };
            btnResetCollection.FlatAppearance.BorderSize = 0;
            btnResetCollection.Click += BtnResetCollection_Click; // Ajouter l'événement pour la réinitialisation

            this.Controls.Add(lblTitle);
            this.Controls.Add(btnBooster);
            this.Controls.Add(btnCollection);
            this.Controls.Add(btnPvp);
            this.Controls.Add(btnResetCollection); // Ajout du bouton Réinitialiser
        }

        // Gestionnaire d'événement pour ouvrir la page de sélection du Booster
        private void BtnBooster_Click(object sender, EventArgs e)
        {
            BoosterSelectionForm boosterForm = new BoosterSelectionForm();
            this.Hide();
            boosterForm.ShowDialog();
            this.Show();
        }

        // Gestionnaire d'événement pour ouvrir la page de collection
        private void BtnCollection_Click(object sender, EventArgs e)
        {
            CollectionForm collectionForm = new CollectionForm();
            this.Hide();
            collectionForm.ShowDialog();
            this.Show();
        }

        // Gestionnaire d'événement pour afficher un message dans le mode PVP
        private void BtnPvp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le mode PVP sera disponible dans une prochaine mise à jour !",
                            "À venir",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // Gestionnaire d'événement pour réinitialiser la collection
        private void BtnResetCollection_Click(object sender, EventArgs e)
        {
            // Demander une confirmation avant de réinitialiser la collection
            var result = MessageBox.Show("Êtes-vous sûr de vouloir réinitialiser votre collection de cartes ? Cette action est irréversible.",
                                         "Confirmation de réinitialisation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Réinitialiser la collection
                CardManager cardManager = new CardManager();
                cardManager.ResetCollection();
            }
        }
    }
}
