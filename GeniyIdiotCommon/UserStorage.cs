using Newtonsoft.Json;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public static class UserStorage
    {
        private static string filePath { get; } = @".\data\TestResults.json";
        public static List<User> GetAll()
        {
            if (!FileManager.Exists(filePath) || FileManager.GetContent(filePath) == string.Empty)
            {
                return new List<User>();
            }
            var fileData = FileManager.GetContent(filePath);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;
        }
        public static void SaveUserResult(User user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            FileManager.Save(filePath, usersResults);
        }
        public static void Clear() => FileManager.Clear(filePath);
    }
}
