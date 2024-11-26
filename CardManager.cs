using MySql.Data.MySqlClient;
using System;

public class CardManager
{
    private string connectionString = "server=localhost;database=pokemon_tcg;user=root;password=";

    public (string nomCarte, string imagePath, string rarete) GetRandomCard()
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
                SELECT Nom, ImagePath, Rareté
                FROM Cartes
                ORDER BY RAND()
                LIMIT 1;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nomCarte = reader.GetString("Nom");
                            imagePath = reader.GetString("ImagePath");
                            rarete = reader.GetString("Rareté");
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
}
