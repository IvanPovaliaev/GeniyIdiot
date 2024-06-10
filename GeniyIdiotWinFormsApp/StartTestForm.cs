using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class StartTestForm : Form
    {
        Game game;

        public StartTestForm()
        {
            game = new Game(StaticData.User);
            MessageBox.Show($"{game.GetTimeLimitMessage()}");
            InitializeComponent();
        }

        private void StartTestForm_Load(object sender, EventArgs e)
        {
            StaticData.User.ResetResults();
            ShowNextQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!InputValidator.TryGetInt32(userAnswerTextBox.Text, out int userAnswer, out string errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            game.AcceptAnswer(userAnswer);
            CheckEnd();
        }

        private void ShowNextQuestion()
        {
            if (game.Countdown != null) game.Countdown.Close();

            timerProgressBar.Value = 0;

            var currentQuestion = game.GetNextQuestion();

            userAnswerTextBox.Text = string.Empty;

            questionNumberLabel.Text = game.GetQuestionNumberText();
            questionTextLabel.Text = currentQuestion.Text;

            Action ShowTimeLeft = () =>
            {
                timerLabel.Text = game.GetTimeLeftMessage();
                try
                {
                    timerProgressBar.Value += 100 / game.TimersSecondsLimit;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    timerProgressBar.Value = 100;
                }
            };
            Action DoAfterEnd = CheckEnd;

            game.StartCountdown(this, ShowTimeLeft, DoAfterEnd);
        }

        private void CheckEnd()
        {
            if (game.End())
            {
                game.Countdown.Close();
                MessageBox.Show(game.CalculateDiagnosis());
                WinFormsProvider.OpenChildForm(new HomeForm());
                return;
            }
            ShowNextQuestion();
        }

        private void StartTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            game.Countdown.Close();
        }
    }
}
