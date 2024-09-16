using DiscordRPC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace Voice_Tale
{
    public class MiscOperations
    {

        // Api Response for Request Console Client
        private DiscordRpcClient client;
        private DateTime startTime;
        private string currentState; // To track the current state

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

        public void OpenForm<T>() where T : Form, new()
        {
            // Checks if the form is already open
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is T)
                {
                    openForm.Focus(); // Brings the existing form to the front
                    return;
                }
            }

            // If the form is not open, create and show a new instance
            T form = new T();
            form.Show();
        }

        public Task RPCInit()
        {


            if (client == null)
            {
                client = new DiscordRpcClient("1285051845496012931");
                client.Initialize();
            }

            
            client.SetPresence(new RichPresence()
            {
                Details = "Township Tale Voice Commands",
                State = "Just got in!",
                Assets = new Assets()
                {
                    LargeImageKey = "yap",
                },
                Buttons = new[]
                {
                    new DiscordRPC.Button() { Label = "GitHub Repo", Url = "https://github.com/ElderToad98/Voice-Tale" },
                    new DiscordRPC.Button() { Label = "Discord", Url = "https://discord.gg/x2uTrdPvsK" }
                },

                Timestamps = Timestamps.Now 
            });

          
            currentState = "Just got in!";

            return Task.CompletedTask;
        }

        public void ChangeDiscordRPC(string newState)
        {
            if (client != null)
            {
                if (currentState != newState)
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = "Township Tale Voice Commands",
                        State = newState, 
                        Assets = new Assets()
                        {
                            LargeImageKey = "yap",
                        },
                        Buttons = new[]
                        {
                            new DiscordRPC.Button() { Label = "GitHub Repo", Url = "https://github.com/ElderToad98/Voice-Tale" },
                            new DiscordRPC.Button() { Label = "Discord", Url = "https://discord.gg/x2uTrdPvsK" }
                        },
                        Timestamps = Timestamps.Now // Resets the timer
                    });

                    // Updates the current state to the new state
                    currentState = newState;
                }
            }
            else
            {
                throw new InvalidOperationException("Discord RPC client is not initialized.");
            }
        }


    }
}
