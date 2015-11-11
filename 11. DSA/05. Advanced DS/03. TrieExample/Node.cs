namespace _03.TrieExample
{
    using System.Collections.Generic;

    public class Node
    {

        public Node()
        {
            this.Edges = new Dictionary<char, Node>();
        }
        public bool IsTerminal
        {
            get
            {
                return Word != null;
            }
        }

        public string Word { get; set; }

        public Dictionary<char, Node> Edges { get; set; }
    }
}
