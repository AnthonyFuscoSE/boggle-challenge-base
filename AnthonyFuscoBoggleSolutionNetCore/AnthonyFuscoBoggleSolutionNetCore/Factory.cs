using System.Collections.Generic;
using AnthonyFuscoBoggleSolutionNetCore.Data;
using AnthonyFuscoBoggleSolutionNetCore.Models;

namespace AnthonyFuscoBoggleSolutionNetCore
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
