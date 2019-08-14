using System;
using System.Collections.Generic;
using System.IO;

namespace AnthonyFuscoBoggleSolution.Data
{
    internal interface IDictionaryRepository
    {
        List<string> GetWords();
    }

    internal class DictionaryRepository : IDictionaryRepository
    {
        public List<string> GetWords()
        {
            var words = new List<string>();

            using (StreamReader sr = File.OpenText(Path.GetFullPath("Data/Dictionary.txt")))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Length >= 3)
                    {
                        words.Add(s);
                    }
                    
                }
            }
          
            return words;
        }
    }
}
