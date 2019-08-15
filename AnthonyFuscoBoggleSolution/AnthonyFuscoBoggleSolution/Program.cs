using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnthonyFuscoBoggleSolution.Data;

namespace AnthonyFuscoBoggleSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            BoggleWordSearchService service = new BoggleWordSearchService(new TrieBuilder(new DictionaryRepository()));
            var words = service.FindWordsInBoggle("EEEOBASOOTALSANI", 4, 4);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
