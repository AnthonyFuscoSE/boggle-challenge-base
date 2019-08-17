using System;

namespace AnthonyFuscoBoggleSolutionNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            IBoggleWordSearchService service = Factory.CreateBoggleWordSearchService();
            
            Console.WriteLine("Please Enter Puzzle as String going from left to right, next line: ");
            string puzzle = Console.ReadLine();

            Console.WriteLine("Please enter the number of Rows:");
            int.TryParse(Console.ReadLine(), out var numOfRows);

            Console.WriteLine("Please enter the number of Columns:");
            int.TryParse(Console.ReadLine(), out var numOfCol);

            try
            {
                var words = service.FindWordsInBoggle(puzzle?.ToUpper(), numOfCol, numOfRows);
                Console.WriteLine($"{Environment.NewLine}Found Words:{Environment.NewLine}");
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
         
            Console.WriteLine("Press any key to quit.");
            Console.ReadLine();
        }
    }
}
