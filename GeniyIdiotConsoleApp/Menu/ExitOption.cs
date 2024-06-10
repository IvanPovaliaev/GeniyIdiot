using System;

namespace GeniyIdiotConsoleApp.Menu
{
    public class ExitOption : MenuOption
    {
        public ExitOption()
        {
            Description = "Выход";
            Option += () => Environment.Exit(0);
        }
    }
}
