using System.Collections.Generic;
using System.Linq;
using GeniyIdiotConsoleApp.Menu;

namespace GeniyIdiotConsoleApp
{
    internal class Program
    {        
        static void Main()
        {
            ConsoleManager.CreateUser();
            var menuOptions = new List<MenuOption>
            {
                new StartOption(),
                new ResultsOption(),
                new QuestionsListOption(),
                new UserChangeOption(),
                new ExitOption()
            };

            while (true)
            {                
                ConsoleManager.ShowMainMenu(menuOptions.Select(option => option.Description));     
                ConsoleManager.SelectOption(menuOptions);   
            }
        }
        
    }
}
