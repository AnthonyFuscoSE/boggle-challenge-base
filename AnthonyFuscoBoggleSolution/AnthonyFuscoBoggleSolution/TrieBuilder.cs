using System;
using System.Collections.Generic;
using System.Linq;
using AnthonyFuscoBoggleSolution.Data;
using AnthonyFuscoBoggleSolution.Models;

namespace AnthonyFuscoBoggleSolution
{
    public interface ITrieBuilder
    {
        List<ITrie> BuildTrie();
    }

    public class TrieBuilder : ITrieBuilder
    {
        private readonly IDictionaryRepository _dictionaryRepository;
        private List<ITrie> _masterList = Factory.CreateTrieList();

        public TrieBuilder(IDictionaryRepository dictionaryRepository)
        {
            _dictionaryRepository = dictionaryRepository ?? throw new ArgumentNullException(nameof(dictionaryRepository));
        }

        public List<ITrie> BuildTrie()
        {
            List<string> words = _dictionaryRepository.GetWords();
            foreach (string word in words)
            {
                GenerateTrie(word.ToUpper(), _masterList);
            }
            return _masterList;
        }

        private void GenerateTrie(string word, List<ITrie> currentNode)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return;
            }

            if (currentNode.FirstOrDefault(x => x.Value == word[0]) == null)
            {
                ITrie currentTrie = Factory.CreateTrie();
                currentTrie.ValidWord = word.Length == 1;
                currentTrie.Value = word[0]; 
                currentNode.Add(currentTrie);
            }

            GenerateTrie(word.Substring(1), currentNode.FirstOrDefault(x => x.Value == word[0]).Children);
        }
    }
}
