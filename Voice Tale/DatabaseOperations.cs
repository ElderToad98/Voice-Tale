using System;
using System.Data.SQLite;

namespace Voice_Tale
{
    internal class DatabaseOperations
    {
        // Connection string
        public string connectionString = "Data Source=voicetale.db;Version=3;";

        // DB Init
        public void InitializeDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS Users (" +
                             "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                             "Name TEXT NOT NULL, " +
                             "InitCompleted INTEGER DEFAULT 0, " +
                             "Username TEXT, " +
                             "PasswordHash TEXT NOT NULL, " +
                             "Password TEXT NOT NULL, " +
                             "ServerId INTEGER DEFAULT 1234)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EnsureUserExists()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Check if there are any users in the database
                string checkSql = "SELECT COUNT(1) FROM Users";
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkSql, conn))
                {
                    long userCount = (long)checkCmd.ExecuteScalar();

                    if (userCount == 0)
                    {
                        // Insert a default user if none exist
                        string insertSql = "INSERT INTO Users (Name, InitCompleted, Username, Password, PasswordHash) " +
                                           "VALUES ('Default Name', 0, 'default_user', 'default_password', 'default_hash')";
                        using (SQLiteCommand insertCmd = new SQLiteCommand(insertSql, conn))
                        {
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        // Changes ServerId
        public void ChangeServerId(int newServerId)
        {
            string sql = "UPDATE Users SET ServerId = @ServerId WHERE ID = (SELECT ID FROM Users LIMIT 1)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ServerId", newServerId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Gets ServerId
        public int GetServerId()
        {
            int serverId = 0; // Default value if no server ID is found
            string sql = "SELECT ServerId FROM Users WHERE ID = (SELECT ID FROM Users LIMIT 1)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("ServerId")))
                            {
                                serverId = reader.GetInt32(reader.GetOrdinal("ServerId"));
                            }
                        }
                    }
                }
            }

            return serverId;
        }

        // Get Username
        public string GetUsername()
        {
            string username = null;
            string sql = "SELECT Username FROM Users WHERE ID = (SELECT ID FROM Users LIMIT 1)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            username = reader["Username"].ToString();
                        }
                    }
                }
            }

            return username;
        }

        public string GetPassword()
        {
            string password = null;
            string sql = "SELECT Password FROM Users WHERE ID = (SELECT ID FROM Users LIMIT 1)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            password = reader["Password"].ToString();
                        }
                    }
                }
            }

            return password;
        }

        public string GetPasswordHash()
        {
            string passwordHash = null;
            string sql = "SELECT PasswordHash FROM Users WHERE ID = (SELECT ID FROM Users LIMIT 1)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            passwordHash = reader["PasswordHash"].ToString();
                        }
                    }
                }
            }

            return passwordHash;
        }
        
        public void ChangeUsernamePassword(string newUsername, string newPassword, string newPasswordHash)
        {

            string sql = "UPDATE Users SET Username = @Username, Password = @Password, PasswordHash = @PasswordHash";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    // Update the username, password, and password hash
                    command.Parameters.AddWithValue("@Username", newUsername);
                    command.Parameters.AddWithValue("@Password", newPassword);  // Store the new password
                    command.Parameters.AddWithValue("@PasswordHash", newPasswordHash);  // Store the new hashed password

                    command.ExecuteNonQuery();
                }
            }
        }





        public void SaveNameToDatabase(string name)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

    
                string updateSql = "UPDATE Users SET Name = @Name WHERE ID = (SELECT ID FROM Users LIMIT 1)";
                using (SQLiteCommand updateCmd = new SQLiteCommand(updateSql, conn))
                {
                    updateCmd.Parameters.AddWithValue("@Name", name);
                    int rowsAffected = updateCmd.ExecuteNonQuery();

        
                    if (rowsAffected == 0)
                    {
                        string insertSql = "INSERT INTO Users (Name) VALUES (@Name)";
                        using (SQLiteCommand insertCmd = new SQLiteCommand(insertSql, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Name", name);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }





        // Gets the user's name from the database
        public string GetName()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT Name FROM Users LIMIT 1";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null; // or throw an exception, or return a default value
                    }
                }
            }
        }

        #region Command Operations
        // Get's file Paths
        public string GetFilePath(string fileName)
        {
            string executablePath = Application.ExecutablePath;
            string executableDirectory = Path.GetDirectoryName(executablePath);
            string filePath = Path.Combine(executableDirectory, fileName);

            if (!File.Exists(filePath))
            {
                // Create the file if it doesn't exist
                File.WriteAllText(filePath, "");
            }

            return filePath;
        }




        public bool SaveCommand(string commandName, string commandString)
        {
            string filePath = GetFilePath("commands.txt");

            // Check if the command already exists
            if (File.ReadAllLines(filePath).Any(line => line.StartsWith(commandName + "(")))
            {
                return false; // Command already exists, don't save
            }

            // Split the string into individual commands based on commas
            List<string> commands = commandString.Split(',').Select(cmd => cmd.Trim()).ToList();

            // Format the command line
            string commandLine = $"{commandName}({string.Join(",", commands)})";

            // Append the new command to the file
            File.AppendAllText(filePath, commandLine + Environment.NewLine);

            return true; // Command saved successfully
        }





        // Gets a command by its name
        public List<string> GetCommandByName(string commandName)
        {
            string filePath = GetFilePath("commands.txt");
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (line.StartsWith(commandName + "("))
                {
                    int startIndex = line.IndexOf('(') + 1;
                    int endIndex = line.LastIndexOf(')');
                    string commandsString = line.Substring(startIndex, endIndex - startIndex);
                    return commandsString.Split(',').ToList();
                }
            }

            return new List<string>(); // Return empty list if command not found
        }

        // Gets all command names
        public List<string> GetAllCommandNames()
        {
            string filePath = GetFilePath("commands.txt");
            string[] lines = File.ReadAllLines(filePath);

            List<string> commandNames = new List<string>();
            foreach (string line in lines)
            {
                int endIndex = line.IndexOf('(');
                if (endIndex > 0)
                {
                    commandNames.Add(line.Substring(0, endIndex));
                }
            }

            return commandNames;
        }



        #endregion

        // Checks if the init is completed
        public bool IsInitCompleted()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT InitCompleted FROM Users LIMIT 1";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && Convert.ToInt32(result) == 1)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        // Marks the init as completed
        public void MarkInitCompleted()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE Users SET InitCompleted = 1 WHERE ID = (SELECT ID FROM Users LIMIT 1)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
