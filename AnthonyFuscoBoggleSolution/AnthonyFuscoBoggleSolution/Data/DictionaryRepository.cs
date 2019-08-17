using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

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
            var assembly = typeof(DictionaryRepository).GetTypeInfo().Assembly;
            var resourceName = assembly.GetManifestResourceNames().First(s => s.EndsWith("Dictionary.txt", StringComparison.CurrentCultureIgnoreCase));

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new InvalidOperationException("Could not load manifest resource stream.");
                }
                using (var sr = new StreamReader(stream))
                {
                    string s = string.Empty;
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s.Length >= 3)
                        {
                            words.Add(s.ToUpper());
                        }
                    }
                }
            }

            return words;
        }
    }
}
