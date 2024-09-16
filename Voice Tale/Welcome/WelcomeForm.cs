using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Diagnostics;
using Bogus;
using ProfanityFilter.Interfaces;
using ProfanityFilter;
using Voice_Tale.Welcome;
using Bogus.DataSets;

namespace Voice_Tale
{
    public partial class WelcomeForm : Form
    {
        private readonly IProfanityFilter _profanityFilter;
        private readonly DatabaseOperations _dbOperations;
        private readonly SpeechRecognitionEngine _recognizer;
        private const float SPEECH_RECOGNITION_THRESHOLD = 0.94f;
        private const int MAX_NAME_LENGTH = 20;

        public WelcomeForm()
        {
            InitializeComponent();
            
            this.ActiveControl = label1;
            _profanityFilter = new ProfanityFilter.ProfanityFilter();
            _dbOperations = new DatabaseOperations();
            _dbOperations.InitializeDatabase();
            _dbOperations.EnsureUserExists();

            _recognizer = new SpeechRecognitionEngine();

            InitializeProfanityFilter();
            InitializeSpeechRecognition();
        }

        private void InitializeProfanityFilter()
        {

            // Forgive me alta for I have sinned
            string[] profanities = { "Fuck", "Shit", "Dick", "Cock", "Sex", "Pussy", "Blowjob", "Gay", "Shlong", "Meat", "Gyat" };


            foreach (var word in profanities)
            {
                _profanityFilter.AddProfanity(word);
            }
        }

        private void InitializeSpeechRecognition()
        {
            
            _recognizer.SetInputToDefaultAudioDevice();

            var nameList = GenerateNames();

            string FormattedNames = "";

            foreach (var name in nameList)
            {
                FormattedNames = FormattedNames + ", "  + name;
            }

            //MessageBox.Show(FormattedNames);

            

            var choices = new Choices(nameList.Select(name => $"my name is {name}").ToArray());
            choices.Add("Hello");
            choices.Add("my name is ElderToad");
            

            var grammarBuilder = new GrammarBuilder(choices);
            var grammar = new Grammar(grammarBuilder);
            _recognizer.LoadGrammar(grammar);

            _recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private List<string> GenerateNames()
        {
            var faker = new Faker();

            

            return Enumerable.Range(0, 5000)
                .Select(_ => faker.Name.FirstName())
                .Where(name => !_profanityFilter.ContainsProfanity(name))
                
                .Distinct()
                .ToList();

            
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence >= SPEECH_RECOGNITION_THRESHOLD && e.Result.Text.StartsWith("my name is", StringComparison.OrdinalIgnoreCase))
            {
                string recognizedName = e.Result.Text.Substring("my name is ".Length).Trim();
                NameBox.Text = recognizedName;
            }

            if (e.Result.Confidence >= SPEECH_RECOGNITION_THRESHOLD && e.Result.Text.StartsWith("Hello", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Hello!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) || _profanityFilter.ContainsProfanity(NameBox.Text))
            {
                MessageBox.Show("Please enter a valid name!");
                return;
            }

            if (MessageBox.Show($"Are you sure you want to be called '{NameBox.Text}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _dbOperations.SaveNameToDatabase(NameBox.Text);
                OpenTownshipLogin();
            }
          
        }

        private void OpenTownshipLogin()
        {
            var townshipLogin = new TownshipLogin();
            townshipLogin.FormClosed += (s, args) => this.Close();
            townshipLogin.Show();
            this.Hide();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (NameBox.Text.Length > MAX_NAME_LENGTH)
            {
                MessageBox.Show($"Name cannot exceed {MAX_NAME_LENGTH} characters!");
                NameBox.Text = NameBox.Text.Substring(0, MAX_NAME_LENGTH);
                NameBox.SelectionStart = NameBox.Text.Length;
            }
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to open Discord?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenUrl("https://discord.gg/u7AVjUt2kZ");
            }
        }



        private void Youtube_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure you want to open Youtube?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenUrl("https://www.youtube.com/@eldertoad98");
            }

        }


        private void Github_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to open Github?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenUrl("https://github.com/ElderToad98/Voice-Tale/tree/master");
            }
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
    }
}