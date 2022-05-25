namespace Sport_App___Course_work__good_part_
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainClockTextBox = new System.Windows.Forms.TextBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ExerciseOrRestLabel = new System.Windows.Forms.Label();
            this.SetCounterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainClockTextBox
            // 
            this.MainClockTextBox.Location = new System.Drawing.Point(51, 79);
            this.MainClockTextBox.Name = "MainClockTextBox";
            this.MainClockTextBox.Size = new System.Drawing.Size(171, 27);
            this.MainClockTextBox.TabIndex = 0;
            this.MainClockTextBox.Text = "00 : 00";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(66, 356);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(125, 45);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Настроить";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(66, 198);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(125, 45);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(66, 274);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(125, 46);
            this.PauseButton.TabIndex = 3;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // ExerciseOrRestLabel
            // 
            this.ExerciseOrRestLabel.AutoSize = true;
            this.ExerciseOrRestLabel.Location = new System.Drawing.Point(79, 32);
            this.ExerciseOrRestLabel.Name = "ExerciseOrRestLabel";
            this.ExerciseOrRestLabel.Size = new System.Drawing.Size(101, 20);
            this.ExerciseOrRestLabel.TabIndex = 4;
            this.ExerciseOrRestLabel.Text = "УПР \\ ОТДЫХ";
            // 
            // SetCounterLabel
            // 
            this.SetCounterLabel.AutoSize = true;
            this.SetCounterLabel.Location = new System.Drawing.Point(75, 131);
            this.SetCounterLabel.Name = "SetCounterLabel";
            this.SetCounterLabel.Size = new System.Drawing.Size(105, 20);
            this.SetCounterLabel.TabIndex = 5;
            this.SetCounterLabel.Text = "Подход 1 из 8";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 433);
            this.Controls.Add(this.SetCounterLabel);
            this.Controls.Add(this.ExerciseOrRestLabel);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.MainClockTextBox);
            this.Name = "MainForm";
            this.Text = "WorkOut Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox MainClockTextBox;
        private Button SettingsButton;
        private Button StartButton;
        private Button PauseButton;
        private Label ExerciseOrRestLabel;
        private Label SetCounterLabel;
    }
}