using System;
using System.Drawing;
using System.IO;
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

                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        pbImageCarte.Image = Image.FromFile(imagePath);
                        pbImageCarte.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur lors du chargement de l'image : " + ex.Message);
                        pbImageCarte.Image = null;
                        DisplayErrorMessage("Erreur 2");
                    }
                }
                else
                {
                    pbImageCarte.Image = null;
                    DisplayErrorMessage("Erreur ");
                }
            }
            else
            {
                lblNomCarte.Text = "Aucune carte trouvée.";
                pbImageCarte.Image = null;
                DisplayErrorMessage("Erreur 1"); 
            }
        }

        private void DisplayErrorMessage(string errorMessage)
        {
            using (Font font = new Font("Arial", 14, FontStyle.Bold))
            {
                Bitmap bmp = new Bitmap(pbImageCarte.Width, pbImageCarte.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White); 
                    g.DrawString(errorMessage, font, Brushes.Red, new PointF(10, pbImageCarte.Height / 2 - 10));
                }
                pbImageCarte.Image = bmp;
                pbImageCarte.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
    }
}
