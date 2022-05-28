using System.Text.RegularExpressions;


namespace Sport_App___Course_work__good_part_
{
    public partial class MainForm : Form
    {
        System.Timers.Timer t;

        private string exerciseTime, restTime, durationTime;
        private bool newDefaultSettings;
        public MainForm(string exerciseTime = "", string restTime = "", string durationTime = "", bool newDefaultSettings = false)
        {
            InitializeComponent();
            this.exerciseTime = exerciseTime;
            this.restTime = restTime;
            this.durationTime = durationTime;

            if(newDefaultSettings) SetNewStartSettings(exerciseTime, durationTime);
        }

        private void SetNewStartSettings(string exerciseTime, string durationTime) 
        {
            ExerciseOrRestLabel.Text = "УПРАЖНЕНИЕ";
            MainClockTextBox.Text = exerciseTime;
            SetCounterLabel.Text = "Подход 1 из "+durationTime;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void SetWorkoutCycles() 
        {
            int[] Times = GetIntValues(exerciseTime, restTime, durationTime);
            int exercise = Times[0];
            int rest = Times[1];
            int duration = Times[2];

            for (int i = 1; i <= duration; i++)
            {
                SetDurationCounterLabel(i, duration); // Подход i из duration
            }
                
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //SetWorkoutCycles();
            int h, m, s;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private int[] GetIntValues(string exercise, string rest, string duration) 
        {
            Regex regex = new Regex(@"[\w]+");

            // int время для Упражнение
            MatchCollection matchesExercise = regex.Matches(exercise);
            int exerciseTimeInt = Convert.ToInt32((string)matchesExercise[0].Value);

            // int время для Отдых
            MatchCollection matchesRest = regex.Matches(rest);
            int restTimeInt = Convert.ToInt32((string)matchesRest[0].Value);

            // int время для Подход
            MatchCollection matchesDuration = regex.Matches(duration);
            int durationTimeInt = Convert.ToInt32((string)matchesDuration[0].Value);

            int[] Times =  { exerciseTimeInt, restTimeInt, durationTimeInt };
            return Times;
        }

        private void SetDurationCounterLabel(int currentCycle, int cyclesTotal) 
        {
            string durationLabel = "Подход " + currentCycle.ToString() + " из " + cyclesTotal.ToString();
            SetCounterLabel.Text = durationLabel;

        }
    }
}