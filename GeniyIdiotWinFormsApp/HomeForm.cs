using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            greetingsLabel.Text = $"Добро пожаловать в игру «ГенийИдиот»\n {StaticData.User.Name}, для продолжения выберите опции из бокового меню";
            StaticData.CloseChildFormButton.Hide();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticData.CloseChildFormButton.Show();
        }
    }
}
