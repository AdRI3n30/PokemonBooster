using System;
using System.Drawing;
using System.Windows.Forms;

namespace PokemonTCG
{
    public partial class MainForm : Form
    {
        private int boosterId; 
        private CardManager cardManager = new CardManager();
        private Label lblNomCarte;
        private PictureBox pbImageCarte;
        private Button btnOuvrirBooster;
        public MainForm(int boosterId)
        {
            this.boosterId = boosterId;
            InitializeComponent();
        }

   
        private void btnOuvrirBooster_Click(object sender, EventArgs e)
        {
            var (nomCarte, imagePath, rarete) = cardManager.GetRandomCardFromBooster(boosterId);

            if (!string.IsNullOrEmpty(nomCarte))
            {
                lblNomCarte.Text = $"{nomCarte} (Rareté : {rarete})";

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pbImageCarte.Image = Image.FromFile(imagePath);
                    pbImageCarte.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbImageCarte.Image = null;
                }
            }
            else
            {
                lblNomCarte.Text = "Aucune carte trouvée.";
                pbImageCarte.Image = null;
            }
        }
    }
}
