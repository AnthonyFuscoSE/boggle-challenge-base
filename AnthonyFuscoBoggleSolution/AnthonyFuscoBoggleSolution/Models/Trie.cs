using System.Collections.Generic;

namespace AnthonyFuscoBoggleSolution.Models
{
    public class Trie
    {
        public bool ValidWord { get; set; }
        public char Value { get; set; }
        public List<Trie> Children { get; set; } = new List<Trie>();
    }
}
