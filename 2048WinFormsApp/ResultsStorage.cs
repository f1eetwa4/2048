using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    internal class ResultsStorage
    {
        private static string path = "results.json";
        public static void AddResult(User user)
        {
            List<User> results = GetResults();
            results.Add(user);
            SaveResults(results);
        }
        public static void SaveResults(List<User> results)
        {
            var jsonResults = JsonConvert.SerializeObject(results);
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(jsonResults);
            }
        }
        public static List<User> GetResults()
        {
            string s;
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    s = sr.ReadToEnd();
                }
                var jsonResults = JsonConvert.DeserializeObject<List<User>>(s) ?? new List<User>();
                return jsonResults;
            }
            return new List<User>();
        }
        public static int FindMaxScore()
        {
            int maxScore = 0;
            List<User> results = GetResults();
            foreach (var user in results)
            {
                if (user.Score > maxScore)
                {
                    maxScore = user.Score;
                }
            }
            return maxScore;
        }
    }

}
