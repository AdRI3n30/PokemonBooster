using MySql.Data.MySqlClient;  // Inclusion de la bibliothèque pour l'accès à MySQL
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

public class CardManager
{
    // Chaîne de connexion pour accéder à la base de données
    private string connectionString = "server=localhost;database=pokemon_tcg;user=root;password=";

    // Cette méthode retourne une carte aléatoire d'un booster donné avec son nom, son image et sa rareté
    public (string nomCarte, string imagePath, string rarete) GetRandomCardFromBooster(int boosterId)
    {
        string nomCarte = null;
        string imagePath = null;
        string rarete = null;
        int cardId = -1;

        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))  // Ouvre une connexion à la base de données
            {
                connection.Open();   // Ouverture de la connexion à la base de données

                // Requête SQL pour récupérer une carte aléatoire à partir d'un booster spécifique
                string query = @"
                SELECT c.id, c.name, c.image_url, c.rarete
                FROM pokemon_cards c
                JOIN booster_cards bc ON c.id = bc.card_id
                WHERE bc.booster_id = @boosterId
                ORDER BY RAND() * c.drop_rate DESC
                LIMIT 1;"; 

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@boosterId", boosterId);

                    using (MySqlDataReader reader = command.ExecuteReader())  
                    {
                        if (reader.Read())  
                        {
                            cardId = reader.GetInt32("id");  
                            nomCarte = reader.GetString("name");  
                            imagePath = reader.GetString("image_url");  
                            rarete = reader.GetString("rarete");  

                            // Vérification de l'existence du fichier image
                            if (!string.IsNullOrEmpty(imagePath) && !File.Exists(imagePath))
                            {
                                Console.WriteLine($"Erreur : L'image de la carte '{nomCarte}' est introuvable à l'emplacement '{imagePath}'.");
                                imagePath = null; 
                            }
                        }
                    }
                }
                // Si une carte a été trouvée, elle est ajoutée à la collection
                if (cardId != -1)
                {
                    AddToCollection(cardId);
                }
            }
        }
        catch (Exception ex)  
        {
            Console.WriteLine("Erreur : " + ex.Message);
        }

        return (nomCarte, imagePath, rarete);  
    }

    // Cette méthode réinitialise la collection de cartes en supprimant toutes les cartes existantes dans la table "collection"
    public void ResetCollection()
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); 

                // Requête SQL pour supprimer toutes les entrées dans la collection
                string query = "DELETE FROM collection";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();  
                    MessageBox.Show("La collection a été réinitialisée avec succès.", "Réinitialisation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show("Erreur lors de la réinitialisation de la collection: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Cette méthode récupère plusieurs cartes d'un booster spécifié et les retourne sous forme de liste
    public List<(string nomCarte, string imagePath, string rarete)> GetCardsFromBooster(int boosterId, int numberOfCards)
    {
        var cards = new List<(string nomCarte, string imagePath, string rarete)>();  

        // Récupération des cartes aléatoires depuis le booster pour un nombre spécifié
        for (int i = 0; i < numberOfCards; i++)
        {
            var card = GetRandomCardFromBooster(boosterId);  
            cards.Add(card);  
        }

        return cards;  
    }

    // Cette méthode ajoute une carte à la collection (ou met à jour sa quantité si elle existe déjà)
    private void AddToCollection(int cardId)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); 

                // Vérification si la carte est déjà présente dans la collection
                string checkQuery = "SELECT Quantité FROM collection WHERE IdCarte = @cardId;";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@cardId", cardId);  
                    object result = checkCommand.ExecuteScalar();  

                    if (result != null)  
                    {
                        
                        string updateQuery = "UPDATE collection SET Quantité = Quantité + 1 WHERE IdCarte = @cardId;";
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@cardId", cardId);
                            updateCommand.ExecuteNonQuery();  
                        }
                    }
                    else  
                    {
                        // Ajout de la nouvelle carte avec une quantité de 1
                        string insertQuery = "INSERT INTO collection (IdCarte, Quantité) VALUES (@cardId, 1);";
                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@cardId", cardId);
                            insertCommand.ExecuteNonQuery();  
                        }
                    }
                }
            }
        }
        catch (Exception ex)  // Gestion des erreurs lors de l'ajout ou de la mise à jour
        {
            Console.WriteLine("Erreur lors de l'ajout à la collection : " + ex.Message);
        }
    }
}
