using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Townsharp.Infrastructure;
using Townsharp.Infrastructure.Configuration;
using Townsharp.Infrastructure.WebApi;

namespace Voice_Tale.Welcome
{
    public partial class TownshipLogin : Form
    {



        DatabaseOperations dbop;
        public IWebApiClient WebApiClient { get; private set; }
        private bool loggingIn = false;
        private CancellationTokenSource animationCancellationTokenSource;




        public TownshipLogin()
        {
            InitializeComponent();
            dbop = new DatabaseOperations();
            Username.Text = dbop.GetName();
            Passwordb.UseSystemPasswordChar = true;
        }



        // Login button click
        private async void Login_Click(object sender, EventArgs e)
        {

            var specName = dbop.GetName();

            if (loggingIn)
            {
                return; // If the logging in proccess has already started
            }

            loggingIn = true;
            animationCancellationTokenSource = new CancellationTokenSource();
            _ = LoadingAnimateAsync(animationCancellationTokenSource.Token);


            string enteredUsername = Username.Text;
            string enteredPassword = Passwordb.Text;

            if (string.IsNullOrWhiteSpace(enteredUsername) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show($"Sorry {specName}, Please enter both username and password.");
                StopAnimation();
                return;
            }

            string hashedPassword = ComputeSha512Hash(enteredPassword);

            try
            {
                UserCredential userCreds = new UserCredential(enteredUsername, hashedPassword, enteredPassword);
                var builder = Builders.CreateUserClientBuilder(userCreds);

                WebApiClient = builder.BuildWebApiClient();

                // timeout mechanism
                var apiCallTask = WebApiClient.GetPendingGroupInvitesAsync();
                var timeoutTask = Task.Delay(TimeSpan.FromSeconds(6)); // 6 second timeout

                var completedTask = await Task.WhenAny(apiCallTask, timeoutTask);

                if (completedTask == timeoutTask)
                {
                    throw new TimeoutException($"Sorry {Name}, The login request timed out. Are your credentials correct?");
                }

                var testAccess = await apiCallTask; // This will throw if the API call failed



                dbop.ChangeUsernamePassword(enteredUsername, enteredPassword, hashedPassword);

                var username = dbop.GetUsername();

                dbop.MarkInitCompleted();

                MessageBox.Show($"Successfully logged in as {username}!\n\nThis window will now close. Please reopen the exe file to get started!");

           

                this.Close();
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred when logging in: {ex.Message}. Please check your credentials and try again.");
            }
            finally
            {
                StopAnimation();
                loggingIn = false;
            }
        }


        // Gets sha512 hash of a password
        private static string ComputeSha512Hash(string rawData)
        {
            using (SHA512 sha512Hash = SHA512.Create())
            {
                byte[] bytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                return BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
            }
        }


        // This is the eye picture that changes the password from visible to not visible
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Passwordb.UseSystemPasswordChar = !Passwordb.UseSystemPasswordChar;
        }



        // Loading Animation For GUI
        private async Task LoadingAnimateAsync(CancellationToken cancellationToken)
        {
            string[] animationFrames = { "Logging in.", "Logging in..", "Logging in..." };
            int frameIndex = 0;

            while (!cancellationToken.IsCancellationRequested)
            {
                await Task.Delay(500, cancellationToken);
                if (cancellationToken.IsCancellationRequested) break;

                this.Invoke((MethodInvoker)delegate
                {
                    Misc.Text = animationFrames[frameIndex];
                });

                frameIndex = (frameIndex + 1) % animationFrames.Length;
            }


        }


        // Stops loading animation
        private void StopAnimation()
        {
            loggingIn = false;
            animationCancellationTokenSource?.Cancel();
            animationCancellationTokenSource?.Dispose();
            animationCancellationTokenSource = null;
            Misc.Text = "";
        }


        private static void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the URL: {ex.Message}");
            }
        }


   
        private void Github_Click(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/ElderToad98/Voice-Tale/tree/master");
        }

        private async void Login_Click_1(object sender, EventArgs e)
        {
            var specName = dbop.GetName();

            if (loggingIn)
            {
                return; // If the logging in proccess has already started
            }

            loggingIn = true;
            animationCancellationTokenSource = new CancellationTokenSource();
            _ = LoadingAnimateAsync(animationCancellationTokenSource.Token);


            string enteredUsername = Username.Text;
            string enteredPassword = Passwordb.Text;

            if (string.IsNullOrWhiteSpace(enteredUsername) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show($"Sorry {specName}, Please enter both username and password.");
                StopAnimation();
                return;
            }

            string hashedPassword = ComputeSha512Hash(enteredPassword);

            try
            {
                UserCredential userCreds = new UserCredential(enteredUsername, hashedPassword, enteredPassword);
                var builder = Builders.CreateUserClientBuilder(userCreds);

                WebApiClient = builder.BuildWebApiClient();

                // timeout mechanism
                var apiCallTask = WebApiClient.GetPendingGroupInvitesAsync();
                var timeoutTask = Task.Delay(TimeSpan.FromSeconds(6)); // 6 second timeout

                var completedTask = await Task.WhenAny(apiCallTask, timeoutTask);

                if (completedTask == timeoutTask)
                {
                    throw new TimeoutException($"Sorry {Name}, The login request timed out. Are your credentials correct?");
                }

                var testAccess = await apiCallTask; // This will throw if the API call failed



                dbop.ChangeUsernamePassword(enteredUsername, enteredPassword, hashedPassword);

                var username = dbop.GetUsername();

                dbop.MarkInitCompleted();

                MessageBox.Show($"Successfully logged in as {username}!\n\nThis window will now close. Please reopen the exe file to get started!");

               

                this.Close();
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred when logging in: {ex.Message}. Please check your credentials and try again.");
            }
            finally
            {
                StopAnimation();
                loggingIn = false;
            }
        }
    }

}
