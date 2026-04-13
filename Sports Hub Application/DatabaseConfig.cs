using System;
using System.IO;

public static class DatabaseConfig
{
    public static string connectionString { get; private set; }

    static DatabaseConfig()
    {
        LoadSqlConfiguration();
    }

    private static void LoadSqlConfiguration()
    {
        // Path: C:\Users\zizo\AppData\Roaming\MyApp\config.txt
        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyApp");
        string configPath = Path.Combine(folderPath, "config.txt");

        if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

        // --- DELETE OLD CONFIG FILE AUTOMATICALLY IF IT EXISTS ---
        // This ensures we start fresh with your correct password "comsys@123"
        // (You can remove this block later once it works)
        if (!File.Exists(configPath) || File.ReadAllText(configPath).Contains("password_here"))
        {
            File.WriteAllLines(configPath, new string[] { "192.168.50.5", "sa", "comsys@123" });
        }

        var lines = File.ReadAllLines(configPath);
        if (lines.Length >= 3)
        {
            string serverName = lines[0].Trim();
            string username = lines[1].Trim();
            string password = lines[2].Trim();

            // FORCE SQL AUTHENTICATION
            // We specifically DO NOT use "Integrated Security=True" here.
            connectionString = $"Data Source={serverName};Initial Catalog=MixedGymDB;User ID={username};Password={password};Encrypt=True;TrustServerCertificate=True;";
        }
        else
        {
            throw new InvalidOperationException("Config file is invalid.");
        }
    }
}