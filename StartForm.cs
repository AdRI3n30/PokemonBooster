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

        public StartForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Accueil Pokémon";
            this.Size = new Size(400, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            btnBooster = new Button
            {
                Text = "Booster",
                Size = new Size(150, 50),
                Location = new Point(120, 80)
            };
            btnBooster.Click += BtnBooster_Click;

            btnCollection = new Button
            {
                Text = "Collection",
                Size = new Size(150, 50),
                Location = new Point(120, 160)
            };
            btnCollection.Click += BtnCollection_Click;


            btnPvp= new Button
            {
                Text = "PVP",
                Size = new Size(150, 50),
                Location = new Point(120, 240)
            };
            btnPvp.Click += BtnPvp_Click;

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
            MessageBox.Show("La collection sera disponible dans une prochaine version !");
        }

        private void BtnPvp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le Pvp sera disponible dans une prochaine version !");
        }
    }
}
