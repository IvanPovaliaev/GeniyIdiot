namespace GeniyIdiotWinFormsApp
{
    partial class QuestionsForm
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
            questionsDataGridView = new System.Windows.Forms.DataGridView();
            clearSelectQuestionButton = new System.Windows.Forms.Button();
            addQustionButton = new System.Windows.Forms.Button();
            questionAnswerTextBox = new System.Windows.Forms.TextBox();
            questionTextTextBox = new System.Windows.Forms.TextBox();
            addQuestionTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            questionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            questionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            questionsDataGridView.BackgroundColor = System.Drawing.Color.Gray;
            questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Location = new System.Drawing.Point(12, 12);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.Size = new System.Drawing.Size(724, 254);
            questionsDataGridView.TabIndex = 3;
            questionsDataGridView.KeyDown += questionsDataGridView_KeyDown;
            // 
            // clearSelectQuestionButton
            // 
            clearSelectQuestionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            clearSelectQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            clearSelectQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            clearSelectQuestionButton.Location = new System.Drawing.Point(602, 370);
            clearSelectQuestionButton.Name = "clearSelectQuestionButton";
            clearSelectQuestionButton.Size = new System.Drawing.Size(120, 60);
            clearSelectQuestionButton.TabIndex = 0;
            clearSelectQuestionButton.Text = "Удалить выделенное";
            clearSelectQuestionButton.UseVisualStyleBackColor = true;
            clearSelectQuestionButton.Click += clearSelectQuestionButton_Click;
            // 
            // addQustionButton
            // 
            addQustionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            addQustionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addQustionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            addQustionButton.Location = new System.Drawing.Point(467, 370);
            addQustionButton.Name = "addQustionButton";
            addQustionButton.Size = new System.Drawing.Size(120, 60);
            addQustionButton.TabIndex = 0;
            addQustionButton.Text = "Добавить вопрос";
            addQustionButton.UseVisualStyleBackColor = true;
            addQustionButton.Click += addQustionButton_Click;
            // 
            // questionAnswerTextBox
            // 
            questionAnswerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            questionAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            questionAnswerTextBox.Location = new System.Drawing.Point(12, 390);
            questionAnswerTextBox.Name = "questionAnswerTextBox";
            questionAnswerTextBox.PlaceholderText = "Введите ответ";
            questionAnswerTextBox.Size = new System.Drawing.Size(240, 23);
            questionAnswerTextBox.TabIndex = 7;
            questionAnswerTextBox.TabStop = false;
            // 
            // questionTextTextBox
            // 
            questionTextTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            questionTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            questionTextTextBox.Location = new System.Drawing.Point(12, 325);
            questionTextTextBox.Name = "questionTextTextBox";
            questionTextTextBox.PlaceholderText = "Введите текст вопроса";
            questionTextTextBox.Size = new System.Drawing.Size(405, 23);
            questionTextTextBox.TabIndex = 5;
            questionTextTextBox.TabStop = false;
            // 
            // addQuestionTextLabel
            // 
            addQuestionTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            addQuestionTextLabel.AutoSize = true;
            addQuestionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            addQuestionTextLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addQuestionTextLabel.Location = new System.Drawing.Point(9, 281);
            addQuestionTextLabel.Margin = new System.Windows.Forms.Padding(0);
            addQuestionTextLabel.Name = "addQuestionTextLabel";
            addQuestionTextLabel.Size = new System.Drawing.Size(156, 20);
            addQuestionTextLabel.TabIndex = 4;
            addQuestionTextLabel.Text = "Добавить вопрос";
            addQuestionTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(748, 442);
            Controls.Add(questionAnswerTextBox);
            Controls.Add(questionTextTextBox);
            Controls.Add(addQuestionTextLabel);
            Controls.Add(addQustionButton);
            Controls.Add(questionsDataGridView);
            Controls.Add(clearSelectQuestionButton);
            Name = "QuestionsForm";
            Text = "Вопросы";
            Load += QuestionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView questionsDataGridView;
        private System.Windows.Forms.Button clearSelectQuestionButton;
        private System.Windows.Forms.Button addQustionButton;
        private System.Windows.Forms.TextBox questionAnswerTextBox;
        private System.Windows.Forms.TextBox questionTextTextBox;
        private System.Windows.Forms.Label addQuestionTextLabel;
    }
}