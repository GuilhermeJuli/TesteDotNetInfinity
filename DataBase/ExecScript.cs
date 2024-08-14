using System;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Data.SqlClient;

public static class SqlScriptExecutor
{
    public static void ExecuteSqlScript(string connectionString, string scriptPath)
    {
        if (!File.Exists(scriptPath))
        {
            Console.WriteLine("Script file not found.");
            return;
        }

        string script = File.ReadAllText(scriptPath);

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string[] commandTexts = script.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var commandText in commandTexts)
                {
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Script executed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
