namespace GeniyIdiotConsoleApp.Menu
{
    public class QuestionDeleteOption : MenuOption
    {
        public QuestionDeleteOption()
        {
            Description = "Удалить вопрос";
            Option = () => ConsoleManager.DeleteQuestion();
        }
    }
}
