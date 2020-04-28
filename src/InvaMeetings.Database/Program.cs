using System;
using DbUp;

namespace InvaMeetings.Database
{
    public class Program
    {
        public static bool IsDevelopment =>
            Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
        static int Main()
        {
            var server = Environment.GetEnvironmentVariable("DB_SERVER");
            var name = Environment.GetEnvironmentVariable("DB_NAME");
            var user = Environment.GetEnvironmentVariable("DB_USER");
            var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            var connectionString = $"Server={server}; Database={name}; Uid={user}; Pwd={password}";
            
            if (IsDevelopment)
            {
                EnsureDatabase.For.SqlDatabase(connectionString);
            }
            
            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithVariable("DatabaseName", name)
                    .WithScriptsFromFileSystem("Scripts")
                    .LogToConsole()
                    .Build();
          
            var result = upgrader.PerformUpgrade();
            
            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
                if (IsDevelopment)
                {
                    Console.ReadLine();
                }
                return -1;
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
            return 0;
        }
    }
}
