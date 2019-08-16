using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnthonyFuscoBoggleSolution.Data;
using AnthonyFuscoBoggleSolution.Models;

namespace AnthonyFuscoBoggleSolution
{
    public static class Factory
    {
        public static ITrie CreateTrie()
        {
            return new Trie();
        }

        public static ITrie CreateTrie(char value, bool validWord, List<ITrie> children)
        {
            return new Trie
            {
                Value = value,
                ValidWord = validWord,
                Children = children
            };
        }

        public static List<ITrie> CreateTrieList()
        {
            return new List<ITrie>();
        }

        public static IDictionaryRepository CreateDictionaryRepository()
        {
            return new DictionaryRepository();
        }

        public static ITrieBuilder CreateTrieBuilder()
        {
            return new TrieBuilder(CreateDictionaryRepository());
        }

        public static IBoggleWordSearchService CreateBoggleWordSearchService()
        {
            return new BoggleWordSearchService(CreateTrieBuilder());
        }
    }
}
