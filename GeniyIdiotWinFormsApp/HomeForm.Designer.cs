namespace GeniyIdiotWinFormsApp
{
    partial class HomeForm
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
            greetingsLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // greetingsLabel
            // 
            greetingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            greetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            greetingsLabel.Location = new System.Drawing.Point(0, 0);
            greetingsLabel.Name = "greetingsLabel";
            greetingsLabel.Size = new System.Drawing.Size(800, 450);
            greetingsLabel.TabIndex = 0;
            greetingsLabel.Text = "Добро пожаловать в игру «ГенийИдиот»!\r\n{User.Name}, для продолжения выберите опции из бокового меню";
            greetingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(greetingsLabel);
            Name = "HomeForm";
            Text = "Домашняя страница";
            FormClosed += HomeForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label greetingsLabel;
    }
}