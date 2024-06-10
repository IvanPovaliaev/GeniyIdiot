namespace GeniyIdiotWinFormsApp
{
    partial class ResultsForm
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
            clearResultsButton = new System.Windows.Forms.Button();
            resultsTableDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)resultsTableDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clearResultsButton
            // 
            clearResultsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            clearResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            clearResultsButton.Location = new System.Drawing.Point(12, 372);
            clearResultsButton.Name = "clearResultsButton";
            clearResultsButton.Size = new System.Drawing.Size(150, 58);
            clearResultsButton.TabIndex = 0;
            clearResultsButton.Text = "Очистить результаты";
            clearResultsButton.UseVisualStyleBackColor = true;
            clearResultsButton.Click += clearResultsButton_Click;
            // 
            // resultsTableDataGridView
            // 
            resultsTableDataGridView.AllowUserToAddRows = false;
            resultsTableDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            resultsTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            resultsTableDataGridView.BackgroundColor = System.Drawing.Color.DimGray;
            resultsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsTableDataGridView.Location = new System.Drawing.Point(12, 12);
            resultsTableDataGridView.Name = "resultsTableDataGridView";
            resultsTableDataGridView.ReadOnly = true;
            resultsTableDataGridView.Size = new System.Drawing.Size(524, 345);
            resultsTableDataGridView.TabIndex = 1;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(548, 442);
            Controls.Add(resultsTableDataGridView);
            Controls.Add(clearResultsButton);
            Name = "ResultsForm";
            Text = "Результаты";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsTableDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView resultsTableDataGridView;
        private System.Windows.Forms.Button clearResultsButton;
    }
}