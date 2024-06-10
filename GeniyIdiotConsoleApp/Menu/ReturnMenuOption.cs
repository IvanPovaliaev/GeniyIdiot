using GeniyIdiotConsoleApp.Exceptions;

namespace GeniyIdiotConsoleApp.Menu
{
    public class ReturnMenuOption : MenuOption
    {
        public ReturnMenuOption()
        {
            Description = "Вернуться в меню";
            Option = () => { throw new ReturnException("Ошибка для выхода в меню выше"); };
        }
    }
}
