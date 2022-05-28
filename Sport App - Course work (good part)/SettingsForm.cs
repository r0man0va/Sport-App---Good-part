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
            ExerciseActionButton_Clicked(false);  // false для "минус"
        }

        private void ExercisePlusButton_Click(object sender, EventArgs e)
        {
            ExerciseActionButton_Clicked(true);  // true для "плюс"
        }

        private void SetExerciseTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            TotalTimeClock();
        }

        private void RestMinusButton_Click(object sender, EventArgs e)
        {
            RestActionButton_Clicked(false);  // false для "минус"
        }

        private void RestPlusButton_Click(object sender, EventArgs e)
        {
            RestActionButton_Clicked(true);  // true для "плюс"
        }

        private void SetRestTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            TotalTimeClock();
        }

        private void DurationMinusButton_Click(object sender, EventArgs e)
        {
            DurationActionButton_Clicked(false);
        }

        private void DurationPlusButton_Click(object sender, EventArgs e)
        {
            DurationActionButton_Clicked(true);
        }

        private void SetDurationCountTextBox_TextChanged(object sender, EventArgs e)
        {
            TotalTimeClock();
        }

        private void ExerciseActionButton_Clicked(bool actionMode) 
        {
            string currentSecondsCount = SetExerciseTimeTextBox.Text;

            Regex regex = new Regex(@"[\w]+");
            MatchCollection matches = regex.Matches(currentSecondsCount);

            int currentSeconds = Convert.ToInt32((string)matches[0].Value);
            int newSeconds;
            if (actionMode) // случай нажатия "плюс" ExercisePlusButton_Click()
            {
                newSeconds = currentSeconds + 1;
            }
            else
            {         // случай нажатия "минус" ExerciseMinusButton_Click()
                newSeconds = currentSeconds - 1;
            }
            if (newSeconds < 0) newSeconds = 0;  // чтоб значения времени не ушли в минус
            
            string newSecondsCount = newSeconds.ToString();
            newSecondsCount += " сек";
            SetExerciseTimeTextBox.Text = newSecondsCount;
        }

        private void RestActionButton_Clicked(bool actionMode) 
        {
            string currentSecondsCount = SetRestTimeTextBox.Text;

            Regex regex = new Regex(@"[\w]+");
            MatchCollection matches = regex.Matches(currentSecondsCount);

            int currentSeconds = Convert.ToInt32((string)matches[0].Value);

            int newSeconds;
            if (actionMode)  // случай нажатия "плюс" RestPlusButton_Click()
            {
                newSeconds = currentSeconds + 1;
            }
            else
            {          // случай нажатия "минус" RestMinusButton_Click()
                newSeconds = currentSeconds - 1;
            }
            if (newSeconds < 0) newSeconds = 0;  // чтоб значения времени не ушли в минус

            string newSecondsCount = newSeconds.ToString();
            newSecondsCount += " сек";
            SetRestTimeTextBox.Text = newSecondsCount;
        }

        private void DurationActionButton_Clicked(bool actionMode) 
        {
            string currentSecondsCount = SetDurationCountTextBox.Text;

            int currentSeconds = Convert.ToInt32(currentSecondsCount);
            int newSeconds;

            if (actionMode)  // случай нажатия "плюс" DurationPlusButton_Click()
            {
                newSeconds = currentSeconds + 1;
            }
            else
            {              // случай нажатия "минус" DurationMinusButton_Click()
                newSeconds = currentSeconds - 1;
            }
            if (newSeconds < 0) newSeconds = 0;  // чтоб значения времени не ушли в минус

            string newSecondsCount = newSeconds.ToString();
            SetDurationCountTextBox.Text = newSecondsCount;
        }

        private void TotalTimeClock() 
        {
            int totalTime = 0;
            Regex regex = new Regex(@"[\w]+");
            
            // работа со временем взятым из Упражнение
            string exerciseTimeStr = SetExerciseTimeTextBox.Text;
            MatchCollection matchesExercize = regex.Matches(exerciseTimeStr);
            int exerciseTime = Convert.ToInt32((string)matchesExercize[0].Value);


            string restTimeStr = SetRestTimeTextBox.Text;
            MatchCollection matchesRest = regex.Matches(restTimeStr);
            int restTime = Convert.ToInt32((string)matchesRest[0].Value);


            string durationCountStr = SetDurationCountTextBox.Text;
            int durationCount = Convert.ToInt32(durationCountStr);

            totalTime = (exerciseTime + restTime) * durationCount;
            string totalTimeStr;
            if (totalTime > 60)
            {
                totalTimeStr = (totalTime/60).ToString() + " мин ";
                totalTimeStr += (totalTime % 60).ToString();
                totalTimeStr += " сек";
                TotalTimeLabelCount.Text = totalTimeStr;
            }
            else {

                TotalTimeLabelCount.Text = (totalTime.ToString()+" сек");
            }
            
            
        }

        private void ConfirmSettingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(SetExerciseTimeTextBox.Text, SetRestTimeTextBox.Text, SetDurationCountTextBox.Text, true);
            mainForm.ShowDialog();
            
        }
    }
}
