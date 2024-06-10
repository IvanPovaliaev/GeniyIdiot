using GeniyIdiot.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class QuestionsForm : Form
    {
        private event Action messageBoxHandler;
        public BindingList<Question> dataList;
        public BindingSource dataSource;
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            dataList = new BindingList<Question>(QuestionsStorage.GetAll());
            dataSource = new BindingSource(dataList, null);

            questionsDataGridView.DataSource = dataSource;
            questionsDataGridView.Columns["Text"].HeaderText = "Вопрос";
            questionsDataGridView.Columns["Answer"].Visible = false;
        }
        private void addQustionButton_Click(object sender, EventArgs e)
        {
            var isInfoCorrect = true;

            if (!InputValidator.TryGetString(questionTextTextBox.Text, out string text, out string textErrorMessage))
            {
                messageBoxHandler += () => MessageBox.Show(textErrorMessage);
                isInfoCorrect = false;
            }
            if (!InputValidator.TryGetInt32(questionAnswerTextBox.Text, out int answer, out string answerErrorMessage))
            {
                messageBoxHandler += () => MessageBox.Show(answerErrorMessage);
                isInfoCorrect = false;
            }

            if (isInfoCorrect) QuestionsStorage.Append(new Question(text, answer));

            messageBoxHandler?.Invoke();
            messageBoxHandler = null;

            dataSource.DataSource = new BindingList<Question>(QuestionsStorage.GetAll());
            questionsDataGridView.Update();
        }
        private void clearSelectQuestionButton_Click(object sender, EventArgs e)
        {
            DeleteSelectedRows();
        }
        private void questionsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteSelectedRows();
        }
        private void DeleteSelectedRows()
        {
            if (questionsDataGridView.SelectedRows.Count > 0)
            {
                for (int i = questionsDataGridView.SelectedRows.Count - 1; i > -1; i--)
                {
                    int rowIndex = questionsDataGridView.SelectedRows[i].Index;
                    questionsDataGridView.Rows.RemoveAt(rowIndex);
                    QuestionsStorage.RemoveAt(rowIndex);
                }

                if (dataList.Count == 0) dataSource.DataSource = new BindingList<Question>(QuestionsStorage.GetAll());
                questionsDataGridView.Update();
            }
        }
    }
}
