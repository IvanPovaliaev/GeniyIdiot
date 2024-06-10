namespace GeniyIdiotWinFormsApp
{
    partial class UserCreationForm
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
            userCreationLabel = new System.Windows.Forms.Label();
            usernameTextBox = new System.Windows.Forms.TextBox();
            userPanel = new System.Windows.Forms.Panel();
            cancelButton = new System.Windows.Forms.Button();
            acceptButton = new System.Windows.Forms.Button();
            backgrounPictureBox = new System.Windows.Forms.PictureBox();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backgrounPictureBox).BeginInit();
            SuspendLayout();
            // 
            // userCreationLabel
            // 
            userCreationLabel.BackColor = System.Drawing.Color.Transparent;
            userCreationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            userCreationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            userCreationLabel.Location = new System.Drawing.Point(20, 36);
            userCreationLabel.Name = "userCreationLabel";
            userCreationLabel.Size = new System.Drawing.Size(373, 23);
            userCreationLabel.TabIndex = 0;
            userCreationLabel.Text = "Введите имя пользователя";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = System.Drawing.SystemColors.Control;
            usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            usernameTextBox.Location = new System.Drawing.Point(20, 95);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(413, 26);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "NoName";
            // 
            // userPanel
            // 
            userPanel.BackColor = System.Drawing.Color.Transparent;
            userPanel.Controls.Add(userCreationLabel);
            userPanel.Controls.Add(cancelButton);
            userPanel.Controls.Add(acceptButton);
            userPanel.Controls.Add(usernameTextBox);
            userPanel.Location = new System.Drawing.Point(90, 76);
            userPanel.Name = "userPanel";
            userPanel.Size = new System.Drawing.Size(462, 201);
            userPanel.TabIndex = 4;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = System.Drawing.Color.Transparent;
            cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cancelButton.Location = new System.Drawing.Point(20, 148);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(130, 30);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = System.Drawing.Color.Transparent;
            acceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            acceptButton.Location = new System.Drawing.Point(303, 148);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new System.Drawing.Size(130, 30);
            acceptButton.TabIndex = 2;
            acceptButton.Text = "Подтвердить";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // backgrounPictureBox
            // 
            backgrounPictureBox.BackColor = System.Drawing.Color.Black;
            backgrounPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            backgrounPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            backgrounPictureBox.Image = Properties.Resources.bg_UserForm;
            backgrounPictureBox.Location = new System.Drawing.Point(0, 0);
            backgrounPictureBox.Name = "backgrounPictureBox";
            backgrounPictureBox.Size = new System.Drawing.Size(640, 360);
            backgrounPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            backgrounPictureBox.TabIndex = 5;
            backgrounPictureBox.TabStop = false;
            // 
            // UserCreationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(640, 360);
            Controls.Add(userPanel);
            Controls.Add(backgrounPictureBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximumSize = new System.Drawing.Size(640, 360);
            MinimumSize = new System.Drawing.Size(640, 360);
            Name = "UserCreationForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "UserCreationForm";
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backgrounPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label userCreationLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        public System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.PictureBox backgrounPictureBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
    }
}