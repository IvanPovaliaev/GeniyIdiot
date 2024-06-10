namespace GeniyIdiotConsoleApp.Menu
{
    public class QuestionAddOption : MenuOption
    {
        public QuestionAddOption()
        {
            Description = "Добавить свой вопрос";
            Option = () => ConsoleManager.AddQuestion();
        }
    }
}
