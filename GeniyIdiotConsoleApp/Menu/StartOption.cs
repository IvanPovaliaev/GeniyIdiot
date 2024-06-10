using GeniyIdiot.Common;


namespace GeniyIdiotConsoleApp.Menu
{
    public class StartOption : MenuOption
    {
        public StartOption()
        {
            Description = "Начать тест";
            Option = () => ConsoleManager.StartTest();                
        }
    }
}
