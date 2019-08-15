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
            Console.WriteLine("Please Enter Puzzle as String going from left to right, next line: ");
            string puzzle = Console.ReadLine();
            Console.WriteLine("Please enter the number of Rows:");
            int numOfRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of Columns:");
            int numOfCol = Convert.ToInt32(Console.ReadLine());

            var words = service.FindWordsInBoggle(puzzle.ToUpper(), numOfCol, numOfRows);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
