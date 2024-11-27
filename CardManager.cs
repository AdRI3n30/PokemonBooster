using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class CardManager
{
    private string connectionString = "server=localhost;database=pokemon_tcg;user=root;password=";

    public (string nomCarte, string imagePath, string rarete) GetRandomCardFromBooster(int boosterId)
    {
        string nomCarte = null;
        string imagePath = null;
        string rarete = null;

        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT c.name, c.image_url, c.rarete
                FROM pokemon_cards c
                JOIN booster_cards bc ON c.id = bc.card_id
                WHERE bc.booster_id = @boosterId
                ORDER BY RAND()
                LIMIT 1;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@boosterId", boosterId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nomCarte = reader.GetString("name");
                            imagePath = reader.GetString("image_url");
                            rarete = reader.GetString("rarete");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erreur : " + ex.Message);
        }

        return (nomCarte, imagePath, rarete);
    }
    public List<(string nomCarte, string imagePath, string rarete)> GetCardsFromBooster(int boosterId, int numberOfCards)
    {
        var cards = new List<(string nomCarte, string imagePath, string rarete)>();

        for (int i = 0; i < numberOfCards; i++)
        {
            var card = GetRandomCardFromBooster(boosterId);
            cards.Add(card);
        }

        return cards;
    }
}
