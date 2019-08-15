using System;
using System.Collections.Generic;
using System.IO;

namespace AnthonyFuscoBoggleSolution.Data
{
    public interface IDictionaryRepository
    {
        List<string> GetWords();
    }

    public class DictionaryRepository : IDictionaryRepository
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
                        words.Add(s.ToUpper());
                    }
                    
                }
            }
          
            return words;
        }
    }
}
