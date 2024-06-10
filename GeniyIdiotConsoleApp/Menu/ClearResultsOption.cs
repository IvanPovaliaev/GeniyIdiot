using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp.Menu
{
    public class ClearResultsOption : MenuOption
    {
        public ClearResultsOption()
        {
            Description = "Очистить таблицу вопросов";
            Option = () => UserStorage.Clear();
        }
    }
}
