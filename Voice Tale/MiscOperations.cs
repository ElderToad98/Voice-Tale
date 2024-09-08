using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Voice_Tale
{
    internal class MiscOperations
    {

        // Api Response for Request Console Client
        private class ApiResponse
        {
            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("error_code")]
            public string ErrorCode { get; set; }
        }


        public async Task <bool> HandleServerConnectionJson(string jsonMessage)
        {
            if (jsonMessage == "" || jsonMessage == null)
            {
                return true;
            }


            jsonMessage = jsonMessage.ToLower();

            // If the server doesn't exist
            if (jsonMessage.StartsWith("could not find any gameserver with identifier"))
            {
                var id = jsonMessage.Split("could not find any gameserver with identifier ")[1];

                MessageBox.Show($"The server you are attempting to connect to does not exist. Ensure you set your server Id is set in the settings.\n\nAttempted server: {id}");
                return false;
                
            }

            // If the server is offline
            else if (jsonMessage.StartsWith("server is not launched with should launch set to false"))
            {

                MessageBox.Show($"The server you are attempting to connect to is offline. Please ensure the server is online.");
                return false;

            }


            // If the message exists but isn't handled
            else if (jsonMessage != "" && jsonMessage != null)
            {
                MessageBox.Show($"Un uncaught message has occured.\n\n{jsonMessage}");
                return false;
            }

            return true;

        }
    }
}
