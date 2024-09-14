using System;
using System.Data.SQLite;
using System.Text.RegularExpressions;

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
                             "ServerId INTEGER DEFAULT 1234, " +
                             "Confidence REAL DEFAULT 0.94, " +
                             "BeepOnCommand INTEGER DEFAULT 0, " +
                             "SpeakOnCommand INTEGER DEFAULT 0)";

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

        public void ChangeConfidence(float newConfidence)
        {
            string sql = "UPDATE Users SET Confidence = @Confidence WHERE ID = (SELECT ID FROM Users LIMIT 1)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Confidence", newConfidence);
                    command.ExecuteNonQuery();
                }
            }
        }




        // Gets Confidence
        public float GetConfidence()
        {
            float Confidence = 0.94f; // Default value if no Confidence is found
            string sql = "SELECT Confidence FROM Users WHERE ID = (SELECT ID FROM Users LIMIT 1)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("Confidence")))
                            {
                                Confidence = (float)reader.GetDouble(reader.GetOrdinal("Confidence"));
                            }
                        }
                    }
                }
            }

            return Confidence;
        }


        public void ChangeBeep(int beep)
        {
            string sql = "UPDATE Users SET BeepOnCommand = @BeepOnCommand WHERE ID = (SELECT ID FROM Users LIMIT 1)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BeepOnCommand", beep);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool IsBeep()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT BeepOnCommand FROM Users LIMIT 1";
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



        public void ChangeVoice(float Voice)
        {
            string sql = "UPDATE Users SET SpeakOnCommand = @SpeakOnCommand WHERE ID = (SELECT ID FROM Users LIMIT 1)";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@SpeakOnCommand", Voice);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool IsVoice()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT SpeakOnCommand FROM Users LIMIT 1";
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

            // Check if the command name or command string contains '(' or ')'
            if (commandName.Contains('(') || commandName.Contains(')') || commandString.Contains('(') || commandString.Contains(')'))
            {
                MessageBox.Show("Command name or command string cannot contain '(' or ')'.");
                return false; // Invalid characters found, don't save
            }

            // Check if the command already exists
            if (File.ReadAllLines(filePath).Any(line => line.ToLower().StartsWith(commandName.ToLower() + "(")))
            {
                MessageBox.Show("Command already exists!\nDelete the command from the file to overwrite!");
                return false; // Command already exists, don't save
            }

            // Split the string into individual commands based on commas
            List<string> commands = commandString.Split(',').Select(cmd => cmd.Trim()).ToList();

            // Format the command line
            string commandLine = $"{commandName}({string.Join(",", commands)})";

            // Append the new command to the file
            File.AppendAllText(filePath, commandLine + Environment.NewLine);

            MessageBox.Show($"Command {commandName} created successfully!");

            return true; // Command saved successfully


        }


        public bool DeleteCommand(string commandName)
        {
            string filePath = GetFilePath("commands.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Commands file not found.");
                return false;
            }

            string[] lines = File.ReadAllLines(filePath);
            List<string> updatedLines = new List<string>();
            bool commandFound = false;

            foreach (string line in lines)
            {
                if (!line.StartsWith(commandName + "("))
                {
                    updatedLines.Add(line);
                }
                else
                {
                    commandFound = true;
                }
            }

            if (!commandFound)
            {
                MessageBox.Show($"Command '{commandName}' not found.");
                return false;
            }

            File.WriteAllLines(filePath, updatedLines);
            MessageBox.Show($"Command '{commandName}' deleted successfully.");
            return true;
        }


        private const string VARIABLES_FILE = "variables.txt";

        // Save a variable to the variables file
        public void SaveVariable(string name, string value)
        {
            string filePath = GetFilePath(VARIABLES_FILE);
            string variableLine = $"{name}={value}";

            // Read existing lines
            List<string> lines = File.Exists(filePath) ? File.ReadAllLines(filePath).ToList() : new List<string>();

            // Update existing variable or add new one
            int existingIndex = lines.FindIndex(line => line.StartsWith(name + "="));
            if (existingIndex != -1)
            {
                lines[existingIndex] = variableLine;
            }
            else
            {
                lines.Add(variableLine);
            }

            // Write all lines back to the file
            File.WriteAllLines(filePath, lines);
        }

        // Load all variables from the variables file
        public Dictionary<string, string> LoadVariables()
        {
            string filePath = GetFilePath(VARIABLES_FILE);
            Dictionary<string, string> variables = new Dictionary<string, string>();

            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    string[] parts = line.Split(new[] { '=' }, 2);
                    if (parts.Length == 2)
                    {
                        variables[parts[0]] = parts[1];
                    }
                }
            }

            return variables;
        }

        // Get a specific variable value
        public string GetVariableValue(string name)
        {
            var variables = LoadVariables();
            return variables.TryGetValue(name, out string value) ? value : null;
        }

        // Delete a variable
        public void DeleteVariable(string name)
        {
            string filePath = GetFilePath(VARIABLES_FILE);
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath).Where(line => !line.StartsWith(name + "="));
                File.WriteAllLines(filePath, lines);
            }
        }

        // Replace variables in a command string
        public string ReplaceVariablesInCommand(string command)
        {
            var variables = LoadVariables();
            return Regex.Replace(command, @"\{(\w+)\}", match =>
            {
                string varName = match.Groups[1].Value;
                return variables.TryGetValue(varName, out string value) ? value : match.Value;
            });
        }

        // Modified GetCommandByName to replace variables
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

                    // Split the commands, but preserve variables in {var} format
                    List<string> commands = new List<string>();
                    int lastIndex = 0;
                    bool inVariable = false;
                    for (int i = 0; i < commandsString.Length; i++)
                    {
                        if (commandsString[i] == '{')
                        {
                            inVariable = true;
                        }
                        else if (commandsString[i] == '}')
                        {
                            inVariable = false;
                        }
                        else if (commandsString[i] == ',' && !inVariable)
                        {
                            commands.Add(ReplaceVariablesInCommand(commandsString.Substring(lastIndex, i - lastIndex).Trim()));
                            lastIndex = i + 1;
                        }
                    }
                    commands.Add(ReplaceVariablesInCommand(commandsString.Substring(lastIndex).Trim()));

                    return commands;
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
