using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace GeniyIdiot.Common
{
    public class Game
    {
        User user;
        private List<Question> questions;
        private Question currentQuestion;
        private int questionNumber;
        public int TimersSecondsLimit { get; private set; }
        private int timersSeconds;
        public System.Timers.Timer Countdown { get; private set; }
        public bool IsTimerEnd { get; private set; }

        public Game(User user)
        {
            this.user = user;
            user.ResetResults();
            TimersSecondsLimit = 10;
            questions = QuestionsStorage.GetAll().Shuffle().ToList();
        }
        public void AcceptAnswer(int userAnswer)
        {
            if (userAnswer == currentQuestion.Answer && !IsTimerEnd)
                user.IncreaseRightAnswers();
        }
        public Question GetNextQuestion()
        {
            currentQuestion = questions[questionNumber];
            questionNumber++;
            return currentQuestion;
        }
        public string GetQuestionNumberText()
        {
            return $"Вопрос №{questionNumber}";
        }
        public string GetTimeLeftMessage()
        {
            return $"Оставшееся время: {timersSeconds} сек.";
        }
        public string GetTimeLimitMessage()
        {
            return $"Внимание! Для ответа на каждый вопрос будет дано {TimersSecondsLimit} сек.";
        }
        public bool End()
        {
            if (questionNumber == questions.Count) return true;
            return false;
        }
        public string CalculateDiagnosis()
        {
            user.Diagnosis = DiagnosisManager.GetDiagnosis(user.CountRightAnswers, questions.Count);
            UserStorage.SaveUserResult(user);

            return $"Пользователь: {user.Name}\nКоличество правильных ответов: {user.CountRightAnswers}\nВаш диагноз: {user.Diagnosis}";
        }
        public void StartCountdown(ISynchronizeInvoke synchObject, Action DoInTick, Action DoAfterEnd)
        {
            IsTimerEnd = false;
            timersSeconds = TimersSecondsLimit;
            DoInTick();

            Countdown = new System.Timers.Timer(1000);
            Countdown.SynchronizingObject = synchObject;

            Countdown.Elapsed += (sender, e) =>
            {
                timersSeconds--;
                DoInTick();
                if (timersSeconds == 0)
                {
                    IsTimerEnd = true;
                    Countdown.Stop();
                    DoAfterEnd();
                }
            };

            Countdown.Start();
        }
    }
}
