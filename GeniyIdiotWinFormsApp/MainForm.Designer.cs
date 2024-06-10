using System.Drawing;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            childFormPanel = new Panel();
            panelMenu = new Panel();
            label2 = new Label();
            currentUserLabel = new Label();
            exitButton = new Button();
            changeUserButtom = new Button();
            questionsButton = new Button();
            resultsButton = new Button();
            startButton = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelTitle = new Panel();
            closeChildFormButton = new Button();
            titleLabel = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // childFormPanel
            // 
            childFormPanel.AutoSize = true;
            childFormPanel.BackColor = Color.FromArgb(32, 30, 45);
            childFormPanel.Dock = DockStyle.Fill;
            childFormPanel.Location = new Point(220, 80);
            childFormPanel.Name = "childFormPanel";
            childFormPanel.Size = new Size(764, 481);
            childFormPanel.TabIndex = 5;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(20, 34, 64);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(currentUserLabel);
            panelMenu.Controls.Add(exitButton);
            panelMenu.Controls.Add(changeUserButtom);
            panelMenu.Controls.Add(questionsButton);
            panelMenu.Controls.Add(resultsButton);
            panelMenu.Controls.Add(startButton);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.Gainsboro;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 561);
            panelMenu.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(0, 453);
            label2.Name = "label2";
            label2.Size = new Size(220, 23);
            label2.TabIndex = 6;
            label2.Text = "Текущий пользователь:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentUserLabel
            // 
            currentUserLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            currentUserLabel.Font = new Font("Microsoft Sans Serif", 10F);
            currentUserLabel.Location = new Point(0, 483);
            currentUserLabel.Name = "currentUserLabel";
            currentUserLabel.Size = new Size(220, 23);
            currentUserLabel.TabIndex = 6;
            currentUserLabel.Text = "currentUserName";
            currentUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Top;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Microsoft Sans Serif", 10F);
            exitButton.ForeColor = Color.Gainsboro;
            exitButton.Image = Properties.Resources.exit;
            exitButton.ImageAlign = ContentAlignment.MiddleLeft;
            exitButton.Location = new Point(0, 260);
            exitButton.Name = "exitButton";
            exitButton.Padding = new Padding(12, 0, 0, 0);
            exitButton.Size = new Size(220, 56);
            exitButton.TabIndex = 5;
            exitButton.Text = " Выход";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // changeUserButtom
            // 
            changeUserButtom.Dock = DockStyle.Bottom;
            changeUserButtom.FlatAppearance.BorderSize = 0;
            changeUserButtom.FlatStyle = FlatStyle.Flat;
            changeUserButtom.Font = new Font("Microsoft Sans Serif", 9F);
            changeUserButtom.ForeColor = Color.Gainsboro;
            changeUserButtom.Image = Properties.Resources.userChange;
            changeUserButtom.ImageAlign = ContentAlignment.MiddleLeft;
            changeUserButtom.Location = new Point(0, 505);
            changeUserButtom.Name = "changeUserButtom";
            changeUserButtom.Padding = new Padding(12, 0, 0, 0);
            changeUserButtom.Size = new Size(220, 56);
            changeUserButtom.TabIndex = 4;
            changeUserButtom.Text = " Сменить пользователя";
            changeUserButtom.TextAlign = ContentAlignment.MiddleLeft;
            changeUserButtom.TextImageRelation = TextImageRelation.ImageBeforeText;
            changeUserButtom.UseVisualStyleBackColor = true;
            changeUserButtom.Click += changeUserButtom_Click;
            // 
            // questionsButton
            // 
            questionsButton.Dock = DockStyle.Top;
            questionsButton.FlatAppearance.BorderSize = 0;
            questionsButton.FlatStyle = FlatStyle.Flat;
            questionsButton.Font = new Font("Microsoft Sans Serif", 10F);
            questionsButton.ForeColor = Color.Gainsboro;
            questionsButton.Image = Properties.Resources.questions;
            questionsButton.ImageAlign = ContentAlignment.MiddleLeft;
            questionsButton.Location = new Point(0, 200);
            questionsButton.Name = "questionsButton";
            questionsButton.Padding = new Padding(12, 0, 0, 0);
            questionsButton.Size = new Size(220, 60);
            questionsButton.TabIndex = 3;
            questionsButton.Text = " Вопросы";
            questionsButton.TextAlign = ContentAlignment.MiddleLeft;
            questionsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            questionsButton.UseVisualStyleBackColor = true;
            questionsButton.Click += questionsButton_Click;
            // 
            // resultsButton
            // 
            resultsButton.Dock = DockStyle.Top;
            resultsButton.FlatAppearance.BorderSize = 0;
            resultsButton.FlatStyle = FlatStyle.Flat;
            resultsButton.Font = new Font("Microsoft Sans Serif", 10F);
            resultsButton.ForeColor = Color.Gainsboro;
            resultsButton.Image = Properties.Resources.results;
            resultsButton.ImageAlign = ContentAlignment.MiddleLeft;
            resultsButton.Location = new Point(0, 140);
            resultsButton.Name = "resultsButton";
            resultsButton.Padding = new Padding(12, 0, 0, 0);
            resultsButton.Size = new Size(220, 60);
            resultsButton.TabIndex = 2;
            resultsButton.Text = " Результаты";
            resultsButton.TextAlign = ContentAlignment.MiddleLeft;
            resultsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            resultsButton.UseVisualStyleBackColor = true;
            resultsButton.Click += resultsButton_Click;
            // 
            // startButton
            // 
            startButton.Dock = DockStyle.Top;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Microsoft Sans Serif", 10F);
            startButton.ForeColor = Color.Gainsboro;
            startButton.Image = Properties.Resources.start;
            startButton.ImageAlign = ContentAlignment.MiddleLeft;
            startButton.Location = new Point(0, 80);
            startButton.Name = "startButton";
            startButton.Padding = new Padding(12, 0, 0, 0);
            startButton.Size = new Size(220, 60);
            startButton.TabIndex = 1;
            startButton.Text = " Начать";
            startButton.TextAlign = ContentAlignment.MiddleLeft;
            startButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(13, 24, 38);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 65);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(84, 29);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 0;
            label1.Text = "ГенийИдиот";
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(88, 115, 163);
            panelTitle.Controls.Add(closeChildFormButton);
            panelTitle.Controls.Add(titleLabel);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(220, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(764, 80);
            panelTitle.TabIndex = 7;
            // 
            // closeChildFormButton
            // 
            closeChildFormButton.FlatAppearance.BorderSize = 0;
            closeChildFormButton.FlatStyle = FlatStyle.Flat;
            closeChildFormButton.Image = Properties.Resources.home;
            closeChildFormButton.Location = new Point(0, 0);
            closeChildFormButton.Name = "closeChildFormButton";
            closeChildFormButton.Size = new Size(55, 80);
            closeChildFormButton.TabIndex = 1;
            closeChildFormButton.UseVisualStyleBackColor = true;
            closeChildFormButton.Click += closeChildFormButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Montserrat", 16F);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(764, 80);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "ГЛАВНАЯ СТРАНИЦА";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(984, 561);
            Controls.Add(childFormPanel);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            ForeColor = SystemColors.Desktop;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ГенийИдиот";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel childFormPanel;
        private Panel panelMenu;
        private Panel panelLogo;
        private Button startButton;
        private Button exitButton;
        private Button changeUserButtom;
        private Button questionsButton;
        private Button resultsButton;
        private Panel panelTitle;
        private Label titleLabel;
        private Label label1;
        private Button closeChildFormButton;
        private Label currentUserLabel;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
