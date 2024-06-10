using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public static class QuestionsStorage
    {
        private static string filePath { get; } = @".\data\Questions.json";
        public static List<Question> GetAll()
        {
            var questions = new List<Question>();

            if (!FileManager.Exists(filePath) || FileManager.GetContent(filePath) == string.Empty)
            {                
                questions.Add(new("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                questions.Add(new("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

                return questions;
            }
            
            var fileData = FileManager.GetContent(filePath);
            questions = JsonConvert.DeserializeObject<List<Question>>(fileData);
            return questions;
        }
        public static void Append(Question question)
        {
            var questions = GetAll();
            questions.Add(question);
            FileManager.Save(filePath, questions);
        }
        public static void Clear() => FileManager.Clear(filePath);
        public static void RemoveAt(int index)
        {
            var questions = GetAll();
            questions.RemoveAt(index);
            FileManager.Save(filePath, questions);
        }
    }
}
