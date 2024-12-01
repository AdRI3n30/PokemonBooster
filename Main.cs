using System.Drawing;
using System.Windows.Forms;
using System;

namespace PokemonTCG
{
    public partial class MainForm : Form
    {
        private int boosterId; 
        private CardManager cardManager = new CardManager();
        private Label lblNomCarte; 
        private PictureBox pbImageCarte; 
        private Button btnOuvrirBooster; 

        // Constructeur de la classe MainForm
        public MainForm(int boosterId)
        {
            this.boosterId = boosterId; 
            InitializeComponent(); 
        }

        // Méthode appelée lors du clic sur le bouton "Ouvrir Booster"
        private void btnOuvrirBooster_Click(object sender, EventArgs e)
        {
            // Récupération des informations de la carte aléatoire dans le booster
            var (nomCarte, imagePath, rarete) = cardManager.GetRandomCardFromBooster(boosterId);

            // Si une carte a été trouvée (nom de la carte n'est pas vide)
            if (!string.IsNullOrEmpty(nomCarte))
            {
                // Mise à jour du texte du label avec le nom de la carte et sa rareté
                lblNomCarte.Text = $"{nomCarte} (Rareté : {rarete})";

                // Si une image est trouvée
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
                        DisplayErrorMessage("Erreur 1"); 
                    }
                }
                else
                {
                    
                    lblNomCarte.Text = "Adresse url vide.";
                    pbImageCarte.Image = null; 
                    DisplayErrorMessage("Erreur 2"); 
                }
            }
            else
            {
                
                lblNomCarte.Text = "Aucune carte trouvée.";
                pbImageCarte.Image = null; 
                DisplayErrorMessage("Erreur 3");
            }
        }

        // Méthode pour afficher un message d'erreur dans le PictureBox
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
