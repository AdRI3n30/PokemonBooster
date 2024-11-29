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
        private Label lblTitle;

        public StartForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
      
            this.Text = "Accueil Pokémon";
            this.Size = new Size(500, 450);
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

            // Bouton "PVP"
            btnPvp = new Button
            {
                Text = "Mode PVP (À venir)",
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 100, 100), 
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(200, 50),
                Location = new Point(150, 280),
                Cursor = Cursors.Hand, 
            };
            btnPvp.FlatAppearance.BorderSize = 0; 
            btnPvp.Click += BtnPvp_Click;

            this.Controls.Add(lblTitle);
            this.Controls.Add(btnBooster);
            this.Controls.Add(btnCollection);
            this.Controls.Add(btnPvp);
        }

        private void BtnBooster_Click(object sender, EventArgs e)
        {
            BoosterSelectionForm boosterForm = new BoosterSelectionForm();
            this.Hide();
            boosterForm.ShowDialog();
            this.Show();
        }

        private void BtnCollection_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La collection sera disponible dans une prochaine version !",
                            "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void BtnPvp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le mode PVP sera disponible dans une prochaine mise à jour !",
                            "À venir",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
