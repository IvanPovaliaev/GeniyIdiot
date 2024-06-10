namespace GeniyIdiotWinFormsApp
{
    partial class StartTestForm
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
            questionNumberLabel = new System.Windows.Forms.Label();
            questionTextLabel = new System.Windows.Forms.Label();
            userAnswerTextBox = new System.Windows.Forms.TextBox();
            nextButton = new System.Windows.Forms.Button();
            timerLabel = new System.Windows.Forms.Label();
            timerProgressBar = new System.Windows.Forms.ProgressBar();
            SuspendLayout();
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            questionNumberLabel.Location = new System.Drawing.Point(55, 62);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new System.Drawing.Size(216, 24);
            questionNumberLabel.TabIndex = 0;
            questionNumberLabel.Text = "questionNumberLabel";
            // 
            // questionTextLabel
            // 
            questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            questionTextLabel.Location = new System.Drawing.Point(55, 143);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new System.Drawing.Size(478, 90);
            questionTextLabel.TabIndex = 0;
            questionTextLabel.Text = "questionText";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            userAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            userAnswerTextBox.Location = new System.Drawing.Point(55, 245);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.PlaceholderText = "Введите свой ответ";
            userAnswerTextBox.Size = new System.Drawing.Size(478, 26);
            userAnswerTextBox.TabIndex = 1;
            // 
            // nextButton
            // 
            nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            nextButton.Location = new System.Drawing.Point(550, 420);
            nextButton.Name = "nextButton";
            nextButton.Size = new System.Drawing.Size(147, 50);
            nextButton.TabIndex = 2;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // timerLabel
            // 
            timerLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            timerLabel.AutoSize = true;
            timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            timerLabel.Location = new System.Drawing.Point(55, 341);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new System.Drawing.Size(107, 24);
            timerLabel.TabIndex = 3;
            timerLabel.Text = "timerLabel";
            // 
            // timerProgressBar
            // 
            timerProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            timerProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            timerProgressBar.ForeColor = System.Drawing.Color.FromArgb(88, 115, 163);
            timerProgressBar.Location = new System.Drawing.Point(0, 493);
            timerProgressBar.Name = "timerProgressBar";
            timerProgressBar.Size = new System.Drawing.Size(764, 10);
            timerProgressBar.TabIndex = 4;
            // 
            // StartTestForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(764, 503);
            Controls.Add(timerProgressBar);
            Controls.Add(timerLabel);
            Controls.Add(nextButton);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Name = "StartTestForm";
            Text = "Тестирование";
            FormClosed += StartTestForm_FormClosed;
            Load += StartTestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ProgressBar timerProgressBar;
    }
}