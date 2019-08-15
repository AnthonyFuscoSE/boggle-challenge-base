using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AnthonyFuscoBoggleSolution.Data;
using AnthonyFuscoBoggleSolution.Models;

namespace AnthonyFuscoBoggleSolution
{
    public interface ITrieBuilder
    {
        List<Trie> BuildTrie();
    }

    public class TrieBuilder : ITrieBuilder
    {
        private readonly IDictionaryRepository _dictionaryRepository;
        private List<Trie> _masterList = new List<Trie>();

        public TrieBuilder(IDictionaryRepository dictionaryRepository)
        {
            _dictionaryRepository = dictionaryRepository ?? throw new ArgumentNullException(nameof(dictionaryRepository));
        }

        public List<Trie> BuildTrie()
        {
            List<string> words = _dictionaryRepository.GetWords();
            foreach (string word in words)
            {
                GenerateTrie(word.ToUpper(), _masterList);
            }
            return _masterList;
        }

        private void GenerateTrie(string word, List<Trie> currentNode)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return;
            }

            if (currentNode.FirstOrDefault(x => x.Value == word[0]) == null)
            {
                currentNode.Add(new Trie { ValidWord = word.Length == 1, Value = word[0] });
            }

            GenerateTrie(word.Substring(1), currentNode.FirstOrDefault(x => x.Value == word[0]).Children);
        }
    }
}
