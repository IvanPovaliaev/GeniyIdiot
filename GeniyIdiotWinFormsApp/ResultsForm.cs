using GeniyIdiot.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class ResultsForm : Form
    {
        public BindingSource dataSource;
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var dataList = new BindingList<User>(UserStorage.GetAll());
            dataSource = new BindingSource(dataList, null);

            resultsTableDataGridView.DataSource = dataSource;
            resultsTableDataGridView.Columns[0].HeaderText = "ФИО";
            resultsTableDataGridView.Columns[1].HeaderText = "Кол-во верных ответов";
            resultsTableDataGridView.Columns[2].HeaderText = "Диагноз";
        }

        private void clearResultsButton_Click(object sender, EventArgs e)
        {
            UserStorage.Clear();
            dataSource.DataSource = new BindingList<User>(UserStorage.GetAll());
        }
    }
}
