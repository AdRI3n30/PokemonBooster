using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PokemonBooster
{
    public class CollectionForm : Form
    {
        private FlowLayoutPanel collectionPanel;
        private string connectionString = "server=localhost;database=pokemon_tcg;user=root;password=";
        private Dictionary<string, Image> imageCache = new Dictionary<string, Image>(); // Cache d'images

        public CollectionForm()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void InitializeComponent()
        {
            this.Text = "Ma Collection de Cartes";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 240, 255);

            // Panneau de défilement pour la collection
            collectionPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(10)
            };
            this.Controls.Add(collectionPanel);

            // Charger la collection depuis la base de données
            ShowCollection(this, collectionPanel);
        }

        // Méthode pour charger la collection depuis la base de données
        public void ShowCollection(Form parentForm, FlowLayoutPanel collectionPanel)
        {
            try
            {
                collectionPanel.SuspendLayout(); // Empêche les recalculs pendant l'ajout des cartes

                // Charger la collection depuis la base de données
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT c.name, c.image_url, col.Quantité
                    FROM collection col
                    JOIN pokemon_cards c ON col.IdCarte = c.id;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Effacer les anciens éléments du panneau
                        collectionPanel.Controls.Clear();

                        while (reader.Read())
                        {
                            string cardName = reader.GetString("name");
                            string imageUrl = reader.GetString("image_url");
                            int quantity = reader.GetInt32("Quantité");

                            // Ajouter la carte dans le FlowLayoutPanel
                            AddCardToPanel(collectionPanel, cardName, imageUrl, quantity);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de la collection : " + ex.Message);
            }
            finally
            {
                collectionPanel.ResumeLayout(); 
            }
        }

        // Méthode pour obtenir une image en cache ou la charger si nécessaire
        private Image GetCardImage(string imageUrl)
        {
            if (!imageCache.ContainsKey(imageUrl))
            {
                try
                {
                    var image = Image.FromFile(imageUrl); 
                    imageCache[imageUrl] = image; 
                }
                catch (Exception)
                {
                    imageCache[imageUrl] = new Bitmap(160, 160); 
                }
            }
            return imageCache[imageUrl];
        }

        // Méthode pour ajouter une carte dans le FlowLayoutPanel
        private void AddCardToPanel(FlowLayoutPanel collectionPanel, string cardName, string imageUrl, int quantity)
        {
            var cardPanel = new Panel
            {
                Width = 150,
                Height = 250,
                Margin = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            var pictureBox = new PictureBox
            {
                Image = GetCardImage(imageUrl),  
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 120,
                Height = 180,
                Dock = DockStyle.Top
            };

            var labelName = new Label
            {
                Text = cardName,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.DarkBlue,
                Padding = new Padding(0, 5, 0, 5)
            };

            var labelQuantity = new Label
            {
                Text = "Quantité: " + quantity,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom,
                Font = new Font("Arial", 9, FontStyle.Regular),
                ForeColor = Color.Black,
                Padding = new Padding(0, 5, 0, 5)
            };

            cardPanel.Controls.Add(pictureBox);
            cardPanel.Controls.Add(labelName);
            cardPanel.Controls.Add(labelQuantity);
            collectionPanel.Controls.Add(cardPanel);
        }
    }
}
