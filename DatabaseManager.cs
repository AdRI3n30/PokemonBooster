using MySql.Data.MySqlClient;

namespace PokemonBoosterSimulator
{
    public class DatabaseManager
    {
        private string connectionString = "server=localhost;database=PokemonDB;uid=root;pwd=yourpassword;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
