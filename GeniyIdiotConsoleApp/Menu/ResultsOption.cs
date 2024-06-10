using System;
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp.Menu
{
    public class ResultsOption : MenuOption
    {
        public ResultsOption()
        {
            Description = "Показать таблицу результатов";
            Option = () =>
            {
                ConsoleManager.ShowResults();
                Console.WriteLine("\nХотите очистить таблицу результатов? (Введите да/нет)");

                if (ConsoleManager.GetYesNoAnswer())
                {
                    UserStorage.Clear();
                    Console.Clear();
                }
            };
        }
    }
}
