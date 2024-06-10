using System;
using System.Linq;
using System.Collections.Generic;
using GeniyIdiotConsoleApp.Exceptions;

namespace GeniyIdiotConsoleApp.Menu
{
    public class QuestionsListOption : MenuOption
    {
        public QuestionsListOption()
        {
            Description = "Показать список вопросов";
            Option = () =>
            {
                while (true)
                {
                    ConsoleManager.ShowQuestions();
                    Console.WriteLine("\nВыберите действие:\n");
                    var questionsMenuOptions = new List<MenuOption>
                            {
                                new QuestionAddOption(),
                                new QuestionDeleteOption(),
                                new ReturnMenuOption()
                            };

                    ConsoleManager.ShowMenuOptions(questionsMenuOptions.Select(option => option.Description));
                    try
                    {
                        ConsoleManager.SelectOption(questionsMenuOptions);
                    }
                    catch (ReturnException)
                    {
                        break;
                    }                    
                }
            };
        }
    }
}
