using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Sport_App___Course_work__good_part_
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ExerciseMinusButton_Click(object sender, EventArgs e)
        {
            string currentSecondsCount = SetExerciseTimeTextBox.Text;

            Regex regex = new Regex(@"[\w]+");
            MatchCollection matches = regex.Matches(currentSecondsCount);

            int currentSeconds = Convert.ToInt32((string)matches[0].Value);
            int newSeconds = currentSeconds - 1;

            string newSecondsCount = newSeconds.ToString();
            newSecondsCount += " сек";
            SetExerciseTimeTextBox.Text = newSecondsCount;

        }

        private void ExercisePlusButton_Click(object sender, EventArgs e)
        {
            string currentSecondsCount = SetExerciseTimeTextBox.Text;

            Regex regex = new Regex(@"[\w]+");
            MatchCollection matches = regex.Matches(currentSecondsCount);

            int currentSeconds = Convert.ToInt32((string)matches[0].Value);
            int newSeconds = currentSeconds + 1;

            string newSecondsCount = newSeconds.ToString();
            newSecondsCount += " сек";
            SetExerciseTimeTextBox.Text = newSecondsCount;
        }

        private void SetExerciseTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RestMinusButton_Click(object sender, EventArgs e)
        {
            string currentSecondsCount = SetRestTimeTextBox.Text;

            Regex regex = new Regex(@"[\w]+");
            MatchCollection matches = regex.Matches(currentSecondsCount);

            int currentSeconds = Convert.ToInt32((string)matches[0].Value);
            int newSeconds = currentSeconds - 1;

            string newSecondsCount = newSeconds.ToString();
            newSecondsCount += " сек";
            SetRestTimeTextBox.Text = newSecondsCount;
        }

        private void RestPlusButton_Click(object sender, EventArgs e)
        {
            string currentSecondsCount = SetRestTimeTextBox.Text;

            Regex regex = new Regex(@"[\w]+");
            MatchCollection matches = regex.Matches(currentSecondsCount);

            int currentSeconds = Convert.ToInt32((string)matches[0].Value);
            int newSeconds = currentSeconds + 1;

            string newSecondsCount = newSeconds.ToString();
            newSecondsCount += " сек";
            SetRestTimeTextBox.Text = newSecondsCount;
        }

        private void SetRestTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DurationMinusButton_Click(object sender, EventArgs e)
        {
            string currentSecondsCount = SetDurationCountTextBox.Text;
            
            int currentSeconds = Convert.ToInt32(currentSecondsCount);
            int newSeconds = currentSeconds - 1;

            string newSecondsCount = newSeconds.ToString();
            SetDurationCountTextBox.Text = newSecondsCount;
        }

        private void DurationPlusButton_Click(object sender, EventArgs e)
        {
            string currentSecondsCount = SetDurationCountTextBox.Text;

            int currentSeconds = Convert.ToInt32(currentSecondsCount);
            int newSeconds = currentSeconds + 1;

            string newSecondsCount = newSeconds.ToString();
            SetDurationCountTextBox.Text = newSecondsCount;
        }

        private void SetDurationCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
