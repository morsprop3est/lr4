namespace test;

using MySql.Data.MySqlClient;
using System;

class Program
{
    static void Main()
    {
        using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=trpz;Uid=root;Pwd=2004;"))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connected to MySQL!");
                
                MySqlCommand selectCommand = new MySqlCommand("SELECT operator_id, name FROM Operator", connection);

                using (MySqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Operator number: {reader.GetInt32("operator_id")}, Name: {reader.GetString("name")}");
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

