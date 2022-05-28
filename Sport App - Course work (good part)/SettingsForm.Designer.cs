namespace Sport_App___Course_work__good_part_
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.ExerciseLabel = new System.Windows.Forms.Label();
            this.ExerciseMinusButton = new System.Windows.Forms.Button();
            this.ExercisePlusButton = new System.Windows.Forms.Button();
            this.SetExerciseTimeTextBox = new System.Windows.Forms.TextBox();
            this.RestLabel = new System.Windows.Forms.Label();
            this.RestMinusButton = new System.Windows.Forms.Button();
            this.RestPlusButton = new System.Windows.Forms.Button();
            this.SetRestTimeTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationMinusButton = new System.Windows.Forms.Button();
            this.DurationPlusButton = new System.Windows.Forms.Button();
            this.SetDurationCountTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmSettingsButton = new System.Windows.Forms.Button();
            this.TotalTimeLabelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Location = new System.Drawing.Point(37, 30);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(112, 20);
            this.TotalTimeLabel.TabIndex = 0;
            this.TotalTimeLabel.Text = "Общее время: ";
            // 
            // ExerciseLabel
            // 
            this.ExerciseLabel.AutoSize = true;
            this.ExerciseLabel.Location = new System.Drawing.Point(129, 88);
            this.ExerciseLabel.Name = "ExerciseLabel";
            this.ExerciseLabel.Size = new System.Drawing.Size(98, 20);
            this.ExerciseLabel.TabIndex = 1;
            this.ExerciseLabel.Text = "Упражнение";
            // 
            // ExerciseMinusButton
            // 
            this.ExerciseMinusButton.Location = new System.Drawing.Point(37, 129);
            this.ExerciseMinusButton.Name = "ExerciseMinusButton";
            this.ExerciseMinusButton.Size = new System.Drawing.Size(34, 33);
            this.ExerciseMinusButton.TabIndex = 2;
            this.ExerciseMinusButton.Text = "-";
            this.ExerciseMinusButton.UseVisualStyleBackColor = true;
            this.ExerciseMinusButton.Click += new System.EventHandler(this.ExerciseMinusButton_Click);
            // 
            // ExercisePlusButton
            // 
            this.ExercisePlusButton.Location = new System.Drawing.Point(275, 135);
            this.ExercisePlusButton.Name = "ExercisePlusButton";
            this.ExercisePlusButton.Size = new System.Drawing.Size(34, 27);
            this.ExercisePlusButton.TabIndex = 3;
            this.ExercisePlusButton.Text = "+";
            this.ExercisePlusButton.UseVisualStyleBackColor = true;
            this.ExercisePlusButton.Click += new System.EventHandler(this.ExercisePlusButton_Click);
            // 
            // SetExerciseTimeTextBox
            // 
            this.SetExerciseTimeTextBox.Location = new System.Drawing.Point(110, 135);
            this.SetExerciseTimeTextBox.Name = "SetExerciseTimeTextBox";
            this.SetExerciseTimeTextBox.Size = new System.Drawing.Size(125, 27);
            this.SetExerciseTimeTextBox.TabIndex = 4;
            this.SetExerciseTimeTextBox.Text = "20 сек";
            this.SetExerciseTimeTextBox.TextChanged += new System.EventHandler(this.SetExerciseTimeTextBox_TextChanged);
            // 
            // RestLabel
            // 
            this.RestLabel.AutoSize = true;
            this.RestLabel.Location = new System.Drawing.Point(129, 189);
            this.RestLabel.Name = "RestLabel";
            this.RestLabel.Size = new System.Drawing.Size(52, 20);
            this.RestLabel.TabIndex = 5;
            this.RestLabel.Text = "Отдых";
            // 
            // RestMinusButton
            // 
            this.RestMinusButton.Location = new System.Drawing.Point(37, 226);
            this.RestMinusButton.Name = "RestMinusButton";
            this.RestMinusButton.Size = new System.Drawing.Size(34, 31);
            this.RestMinusButton.TabIndex = 6;
            this.RestMinusButton.Text = "-";
            this.RestMinusButton.UseVisualStyleBackColor = true;
            this.RestMinusButton.Click += new System.EventHandler(this.RestMinusButton_Click);
            // 
            // RestPlusButton
            // 
            this.RestPlusButton.Location = new System.Drawing.Point(275, 226);
            this.RestPlusButton.Name = "RestPlusButton";
            this.RestPlusButton.Size = new System.Drawing.Size(34, 31);
            this.RestPlusButton.TabIndex = 7;
            this.RestPlusButton.Text = "+";
            this.RestPlusButton.UseVisualStyleBackColor = true;
            this.RestPlusButton.Click += new System.EventHandler(this.RestPlusButton_Click);
            // 
            // SetRestTimeTextBox
            // 
            this.SetRestTimeTextBox.Location = new System.Drawing.Point(110, 230);
            this.SetRestTimeTextBox.Name = "SetRestTimeTextBox";
            this.SetRestTimeTextBox.Size = new System.Drawing.Size(125, 27);
            this.SetRestTimeTextBox.TabIndex = 8;
            this.SetRestTimeTextBox.Text = "10 сек";
            this.SetRestTimeTextBox.TextChanged += new System.EventHandler(this.SetRestTimeTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(129, 289);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(61, 20);
            this.DurationLabel.TabIndex = 9;
            this.DurationLabel.Text = "Подход";
            // 
            // DurationMinusButton
            // 
            this.DurationMinusButton.Location = new System.Drawing.Point(37, 326);
            this.DurationMinusButton.Name = "DurationMinusButton";
            this.DurationMinusButton.Size = new System.Drawing.Size(34, 29);
            this.DurationMinusButton.TabIndex = 10;
            this.DurationMinusButton.Text = "-";
            this.DurationMinusButton.UseVisualStyleBackColor = true;
            this.DurationMinusButton.Click += new System.EventHandler(this.DurationMinusButton_Click);
            // 
            // DurationPlusButton
            // 
            this.DurationPlusButton.Location = new System.Drawing.Point(275, 328);
            this.DurationPlusButton.Name = "DurationPlusButton";
            this.DurationPlusButton.Size = new System.Drawing.Size(34, 27);
            this.DurationPlusButton.TabIndex = 11;
            this.DurationPlusButton.Text = "+";
            this.DurationPlusButton.UseVisualStyleBackColor = true;
            this.DurationPlusButton.Click += new System.EventHandler(this.DurationPlusButton_Click);
            // 
            // SetDurationCountTextBox
            // 
            this.SetDurationCountTextBox.Location = new System.Drawing.Point(110, 328);
            this.SetDurationCountTextBox.Name = "SetDurationCountTextBox";
            this.SetDurationCountTextBox.Size = new System.Drawing.Size(125, 27);
            this.SetDurationCountTextBox.TabIndex = 12;
            this.SetDurationCountTextBox.Text = "4";
            this.SetDurationCountTextBox.TextChanged += new System.EventHandler(this.SetDurationCountTextBox_TextChanged);
            // 
            // ConfirmSettingsButton
            // 
            this.ConfirmSettingsButton.Location = new System.Drawing.Point(129, 409);
            this.ConfirmSettingsButton.Name = "ConfirmSettingsButton";
            this.ConfirmSettingsButton.Size = new System.Drawing.Size(94, 29);
            this.ConfirmSettingsButton.TabIndex = 13;
            this.ConfirmSettingsButton.Text = "Начать";
            this.ConfirmSettingsButton.UseVisualStyleBackColor = true;
            // 
            // TotalTimeLabelCount
            // 
            this.TotalTimeLabelCount.AutoSize = true;
            this.TotalTimeLabelCount.Location = new System.Drawing.Point(186, 31);
            this.TotalTimeLabelCount.Name = "TotalTimeLabelCount";
            this.TotalTimeLabelCount.Size = new System.Drawing.Size(50, 20);
            this.TotalTimeLabelCount.TabIndex = 14;
            this.TotalTimeLabelCount.Text = "2 мин";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 451);
            this.Controls.Add(this.TotalTimeLabelCount);
            this.Controls.Add(this.ConfirmSettingsButton);
            this.Controls.Add(this.SetDurationCountTextBox);
            this.Controls.Add(this.DurationPlusButton);
            this.Controls.Add(this.DurationMinusButton);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.SetRestTimeTextBox);
            this.Controls.Add(this.RestPlusButton);
            this.Controls.Add(this.RestMinusButton);
            this.Controls.Add(this.RestLabel);
            this.Controls.Add(this.SetExerciseTimeTextBox);
            this.Controls.Add(this.ExercisePlusButton);
            this.Controls.Add(this.ExerciseMinusButton);
            this.Controls.Add(this.ExerciseLabel);
            this.Controls.Add(this.TotalTimeLabel);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TotalTimeLabel;
        private Label ExerciseLabel;
        private Button ExerciseMinusButton;
        private Button ExercisePlusButton;
        private TextBox SetExerciseTimeTextBox;
        private Label RestLabel;
        private Button RestMinusButton;
        private Button RestPlusButton;
        private TextBox SetRestTimeTextBox;
        private Label DurationLabel;
        private Button DurationMinusButton;
        private Button DurationPlusButton;
        private TextBox SetDurationCountTextBox;
        private Button ConfirmSettingsButton;
        private Label TotalTimeLabelCount;
    }
}