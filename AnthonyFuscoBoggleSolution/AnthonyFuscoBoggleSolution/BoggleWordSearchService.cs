using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnthonyFuscoBoggleSolution.Data;

namespace AnthonyFuscoBoggleSolution
{
    public interface IBoggleWordSearchService
    {
        HashSet<string> FindWordsInBoggle(string boggleBoard);
    }
    public class BoggleWordSearchService : IBoggleWordSearchService
    {
        private readonly IDictionaryRepository _dictionaryRepository;

        public BoggleWordSearchService(IDictionaryRepository dictionaryRepository)
        {
            _dictionaryRepository = dictionaryRepository ?? throw new ArgumentNullException(nameof(dictionaryRepository));
        }

        public HashSet<string> FindWordsInBoggle(string boggleBoard)
        {
            HashSet<string> foundWords = new HashSet<string>();
            
            //validate that is valid boggleboard
            // correct # of char
            // no invalid characters



            return foundWords;
        }

        internal bool IsValidBoggleBoard(string board)
        {
            var result = false;

            return result;
        }
    }
}
