using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GeniyIdiot.Common
{
    public static class FileManager
    {
        private static void CreateFile(string filePath)
        {
            var dirPath = new DirectoryInfo(Path.GetDirectoryName(filePath));
            if (!dirPath.Exists) dirPath.Create();
            if (!File.Exists(filePath)) File.Create(filePath).Close();
        }
        public static void Replace(string filePath, string content)
        {
            CreateFile(filePath);
            using (var sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(content);
            }
        }
        public static string GetContent(string filePath)
        {
            CreateFile(filePath);
            return File.ReadAllText(filePath, System.Text.Encoding.Default);
        }
        public static void Clear(string filePath) => File.WriteAllText(filePath, string.Empty);
        public static bool Exists(string filePath) => File.Exists(filePath);
        public static void Save<T>(string filePath, List<T> dataList)
        {
            if (dataList.Count == 0)
            {
                Clear(filePath);
                return;
            }
            var jsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            Replace(filePath, jsonData);
        }
    }
}
