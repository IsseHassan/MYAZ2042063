using Microsoft.Data.Sqlite;

namespace DatabaseFinal
{
    public class program
    {
        static void Main(string[] args)
        {

            string ConnectionString = "Data Source=C:\\Users\\Public\\MYAZ2042063\\DataStructuresAndAlgorithms\\DatabaseFinal\\DatabaseFinal\\Database.db";
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand("SELECT * FROM Employees WHERE Salary%250 = 0", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        decimal salary = reader.GetDecimal(2);

                        // Display the retrieved data in the console
                        Console.WriteLine($"Employee - ID: {id}, Name: {name}, Salary: {salary}");

                    }
                    //connection.Close();
                }
                Console.ReadKey();
            }
        }
    }
}









