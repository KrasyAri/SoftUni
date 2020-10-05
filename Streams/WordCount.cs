using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> repeatedWords = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader("../../../words.txt"))
            {
                var allWords = reader.ReadToEnd();
                string[] word = allWords.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

                using (StreamReader text = new StreamReader("../../../text.txt"))
                {
                    var inputText = text.ReadToEnd();
                    string[] inputTextWords = inputText.Split(' ','-',',','.','?', '!');

                    for (int i = 0; i < word.Length; i++)
                    {
                        string currentWord = word[i];

                        for (int j = 0; j < inputTextWords.Length; j++)
                        {
                            string currentFromText = inputTextWords[j];
                            if (currentWord.ToLower() == currentFromText.ToLower())
                            {
                                if (!repeatedWords.ContainsKey(currentWord))
                                {
                                    repeatedWords.Add(currentWord, 0);
                                }
                                repeatedWords[currentWord]++;
                            }
                        }
                    }
                    
                }
                
            }
            var sorted = repeatedWords.OrderByDescending(v => v.Value);

            using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
            {
                foreach (var item in sorted)
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
