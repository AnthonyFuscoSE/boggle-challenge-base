using System.Collections.Generic;

namespace AnthonyFuscoBoggleSolution.Models
{
    public interface ITrie
    {
        bool ValidWord { get; set; }
        char Value { get; set; }
        List<ITrie> Children { get; set; }
    }

    public class Trie : ITrie
    {
        public bool ValidWord { get; set; }
        public char Value { get; set; }
        public List<ITrie> Children { get; set; } = Factory.CreateTrieList();
    }
}
