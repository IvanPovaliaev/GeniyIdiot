using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using GeniyIdiot.Common;
using GeniyIdiotConsoleApp.Menu;

namespace GeniyIdiotConsoleApp
{
    public static class ConsoleManager
    {
        private static Game game;
        public static void CreateUser()
        {
            Console.Clear();
            Console.WriteLine("Введите имя пользователя:");
            StaticData.User = new User(Console.ReadLine());
        }
        public static void AddQuestion()
        {
            Console.WriteLine("\nВведите текст вопроса:");
            var questionText = GetStringAnswer();

            Console.WriteLine("\n\nВведите ответ на вопрос в виде целого числа:");
            var questionAnswer = GetInt32Answer();

            QuestionsStorage.Append(new Question(questionText, questionAnswer));
        }
        public static void DeleteQuestion()
        {
            Console.WriteLine("\nВведите номер вопроса, который хотите удалить:");
            var questions = QuestionsStorage.GetAll();

            var questionNumber = GetInt32Answer(1, questions.Count);
            QuestionsStorage.RemoveAt(questionNumber - 1);
        }
        public static void SelectOption(IEnumerable<MenuOption> options)
        {
            var optionsArray = options.ToArray();
            var selectionNumb = 0;
            ConsoleKey key = default;
            Console.CursorVisible = false;

            var currentPosition = Console.GetCursorPosition();

            Console.WriteLine("\nДля выбора действия используйте кнопки ↑ и ↓ на клавиатуре");
            Console.WriteLine("Для подтверждения действия нажмите Enter");
            Console.SetCursorPosition(0, currentPosition.Top - optionsArray.Length);
            currentPosition = Console.GetCursorPosition();

            while (key != ConsoleKey.Enter)
            {
                for (int i = 0; i < optionsArray.Length; i++)
                {
                    if (i == selectionNumb)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    ShowMenuOption(i + 1, optionsArray[i].Description);
                    Console.WriteLine();
                    Console.ResetColor();
                }
                Console.SetCursorPosition(currentPosition.Left, currentPosition.Top);

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (selectionNumb > 0) selectionNumb--;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (selectionNumb < optionsArray.Length - 1) selectionNumb++;
                            break;
                        }
                }
            }
            Console.SetCursorPosition(0, currentPosition.Top + optionsArray.Length + 3);
            Console.CursorVisible = true;
            optionsArray[selectionNumb].Option();
        }
        public static void ShowMainMenu(IEnumerable<string> menuDescription)
        {
            Console.Clear();
            Console.WriteLine(@"«Гений-Идиот. Главное меню»");
            Console.WriteLine($"Текущий пользователь: {StaticData.User.Name}");
            Console.WriteLine();

            ShowMenuOptions(menuDescription);
        }
        public static void ShowMenuOption(int position, string optionDescription)
        {
            Console.Write($"{position}. {optionDescription}");
        }
        public static void ShowMenuOptions(IEnumerable<string> menuDescriptions)
        {
            var descriptions = menuDescriptions.ToArray();
            for (int i = 0; i < descriptions.Length; i++)
            {
                ShowMenuOption(i + 1, descriptions[i]);
                Console.WriteLine();
            }
        }
        public static void ShowResults()
        {
            Console.Clear();
            Console.WriteLine($"|| {"ФИО",-15} || {"Кол-во правильных ответов",-30} || {"Диагноз",-20}");
            var users = UserStorage.GetAll();

            foreach (var user in users)
            {
                Console.WriteLine($"|| {user.Name,-15} || {user.CountRightAnswers,-30} || {user.Diagnosis,-20}");
            }
        }
        public static void ShowQuestions()
        {
            Console.Clear();
            Console.WriteLine($"|| {"№ вопроса",-15} || {"Вопрос",-30}");
            var questions = QuestionsStorage.GetAll();

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"|| {i+1,-15} || {questions[i].Text,-30}");
            }    
        }
        public static void ShowNextQuestion()
        {
            if (game.Countdown != null) game.Countdown.Close();
            var currentQuestion = game.GetNextQuestion();

            Console.WriteLine(game.GetQuestionNumberText());
            Console.WriteLine($"{currentQuestion.Text}\n");
            var progressBar = new ProgressBar();

            Action ShowTime = () => ShowTimeLeft(progressBar);
            Action DoAfterEnd = () =>
            {
                Console.Write("\n" + new string(' ', Console.WindowWidth) + "\n");
            };

            game.StartCountdown(null, ShowTime, DoAfterEnd);
        }
        public static void StartTest()
        {            
            game = new Game(StaticData.User);

            Console.CursorVisible = false;
            
            while (!game.End())
            {
                Console.Clear();
                Console.WriteLine($"{game.GetTimeLimitMessage()}\n");
                ShowNextQuestion();

                var userAnswer = 0;

                while (true)
                {
                    if (InputValidator.TryGetInt32(ReadLineLimit(game.TimersSecondsLimit*1000), out int number, out string errorMessage))
                    {
                        userAnswer = number;
                        break;
                    }
                    if (game.IsTimerEnd) break;
                    WriteErrorMessage(errorMessage);
                }

                Console.WriteLine("\n");

                game.AcceptAnswer(userAnswer);
                game.Countdown.Close();
            }            

            Console.Clear();
            Console.WriteLine(game.CalculateDiagnosis());

            Console.CursorVisible = true;
            Console.WriteLine("\nДля перехода в главное меню нажмите любую клавишу");
            Console.ReadKey();
        }
        public static void ShowTimeLeft(ProgressBar progressBar)
        {
            var cursorPosition = Console.GetCursorPosition();
            Console.SetCursorPosition(0, cursorPosition.Top - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.Write($"\r{game.GetTimeLeftMessage()}");

            Console.ForegroundColor = ConsoleColor.Blue;
            
            var progressIncrement = progressBar.MaxValue / game.TimersSecondsLimit;

            progressBar.IncreaseProgresse(progressIncrement);
            Console.Write($"\t{progressBar.GetProgressBar()}");

            Console.SetCursorPosition(cursorPosition.Left, cursorPosition.Top);
            Console.ResetColor();
        }
        public static int GetInt32Answer()
        {
            while (true)
            {
                if (InputValidator.TryGetInt32(Console.ReadLine(), out int number, out string errorMessage))
                {
                    return number;
                }
                WriteErrorMessage(errorMessage);
            }
        }
        public static int GetInt32Answer(int minValue, int maxValue)
        {
            while (true)
            {
                if (InputValidator.TryGetInt32(Console.ReadLine(), minValue, maxValue, out int number, out string errorMessage))
                {
                    return number;
                }
                WriteErrorMessage(errorMessage);
            }
        }
        public static string GetStringAnswer()
        {
            while (true)
            {
                if (InputValidator.TryGetString(Console.ReadLine(), out string text, out string errorMessage))
                {
                    return text;
                }
                WriteErrorMessage(errorMessage);
            }
        }
        public static bool GetYesNoAnswer()
        {
            while (true)
            {
                var userAnswer = Console.ReadLine().ToLower();
                if (userAnswer != "да" && userAnswer != "нет")
                {
                    WriteErrorMessage("Неверные входные данные (Введите да/нет)");
                    continue;
                }
                if (userAnswer == "нет") return false;
                break;
            }
            return true;
        }
        public static void WriteErrorMessage(string message)
        {
            var cursorPosition = Console.GetCursorPosition();
            Console.WriteLine(message);
            Console.SetCursorPosition(cursorPosition.Left, cursorPosition.Top - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(cursorPosition.Left, cursorPosition.Top - 1);
        }
        public static string ReadLineLimit(int limit)
        {
            var input = string.Empty;

            while (!game.IsTimerEnd)
            {
                Thread.Sleep(11); //Небольшая задержка ввода, чтобы не перекрывать сообщения
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(intercept: true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine();
                        return input;
                    }
                    else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                    {
                        input = input.Substring(0, input.Length - 1);
                        Console.Write("\b \b");
                    }
                    else
                    {
                        input += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
            }
            return string.Empty;
        }
    }
}
