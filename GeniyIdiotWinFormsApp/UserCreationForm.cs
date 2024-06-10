using GeniyIdiot.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class UserCreationForm : DoubleBufferedForm
    {
        public UserCreationForm()
        {
            InitializeComponent();
            userPanel.Parent = backgrounPictureBox;

            StaticData.MainForm?.Hide();

            if (StaticData.User != null) usernameTextBox.Text = StaticData.User.Name;
            userPanel.BackColor = Color.FromArgb(50, Color.White);
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            StaticData.User = new User(usernameTextBox.Text);
            StaticData.MainForm?.Show();
            Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (StaticData.User != null)
            {
                StaticData.MainForm?.Show();
                Close();
            }
            else Application.Exit();
        }
    }
}
