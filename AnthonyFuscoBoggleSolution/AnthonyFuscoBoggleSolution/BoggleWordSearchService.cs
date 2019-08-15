using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AnthonyFuscoBoggleSolution.Data;

namespace AnthonyFuscoBoggleSolution
{
    public interface IBoggleWordSearchService
    {
        HashSet<string> FindWordsInBoggle(string boggleBoard, int numberOfColumns, int numberofRows);
    }
    public class BoggleWordSearchService : IBoggleWordSearchService
    {
        //private readonly IDictionaryRepository _dictionaryRepository;

        //public BoggleWordSearchService(IDictionaryRepository dictionaryRepository)
        //{
        //    _dictionaryRepository = dictionaryRepository ?? throw new ArgumentNullException(nameof(dictionaryRepository));
        //}

        public HashSet<string> FindWordsInBoggle(string boggleBoard, int numberOfColumns, int numberofRows)
        {
            HashSet<string> foundWords = new HashSet<string>();

            if (!IsValidBoggleBoard(boggleBoard, numberOfColumns, numberofRows))
            {
                throw new ArgumentException($"{boggleBoard} does not make a valid boggle board {nameof(boggleBoard)}");
            }

            //Build Main Trie
            //build array of boggle board based on string / params
            //create depth first search
            

            return foundWords;
        }

        internal bool IsValidBoggleBoard(string board, int numberOfColumns, int numberOfRows)
        {
            if (string.IsNullOrWhiteSpace(board))
            {
                return false;
            }

            if (board.Length != numberOfColumns * numberOfRows)
            {
                return false;
            }

            Regex r = new Regex("[^A-Z]");
            if (r.IsMatch(board.ToUpper()))
            {
                return false;
            }

            return true;
        }
    }
}
