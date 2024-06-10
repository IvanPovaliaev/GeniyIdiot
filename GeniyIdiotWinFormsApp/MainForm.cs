using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private Button currentButton;

        public MainForm()
        {
            InitializeComponent();
            StaticData.TitleLabel = titleLabel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StaticData.MainForm = this;
            StaticData.ChildFormPanel = childFormPanel;
            StaticData.CloseChildFormButton = closeChildFormButton;

            new UserCreationForm().ShowDialog();
            currentUserLabel.Text = $"{StaticData.User.Name}";

            WinFormsProvider.OpenChildForm(new HomeForm());
        }
        private void ActivateButton(object btnSender)
        {
            ResetButtonColor();
            currentButton = (Button)btnSender;
            currentButton.BackColor = ColorTranslator.FromHtml("#84C1D9");
            currentButton.ForeColor = Color.White;
            currentButton.Font = new Font("Microsoft Sans Serif", 12F);
        }
        private void ResetButtonColor()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton is Button)
                {
                    previousButton.BackColor = Color.FromArgb(20, 34, 64);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new Font("Microsoft Sans Serif", 10F);
                }
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            changeUserButtom.Enabled = false;
            var startTest = new StartTestForm();
            startTest.FormClosed += (s, e) =>
            {
                changeUserButtom.Enabled = true;
                ResetButtonColor();
            };

            WinFormsProvider.OpenChildForm(startTest);
        }
        private void resultsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            WinFormsProvider.OpenChildForm(new ResultsForm());
        }
        private void questionsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            WinFormsProvider.OpenChildForm(new QuestionsForm());
        }
        private void changeUserButtom_Click(object sender, EventArgs e)
        {
            Hide();
            new UserCreationForm().ShowDialog();
            currentUserLabel.Text = StaticData.User.Name;
        }
        private void closeChildFormButton_Click(object sender, EventArgs e)
        {
            StaticData.ActiveForm.Close();
            ResetButtonColor();
            WinFormsProvider.OpenChildForm(new HomeForm());
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
