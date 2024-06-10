using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public static class WinFormsProvider
    {
        public static void OpenChildForm(Form childForm)
        {
            if (StaticData.ActiveForm != null && !StaticData.ActiveForm.IsDisposed) StaticData.ActiveForm.Close();

            StaticData.ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            StaticData.MainForm.BeginInvoke(() =>
            {
                StaticData.ChildFormPanel.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            });
            StaticData.TitleLabel.Text = childForm.Text;
        }
    }
}
