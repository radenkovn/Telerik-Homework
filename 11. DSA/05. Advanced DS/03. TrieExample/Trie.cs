namespace _03.TrieExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //Taken from internet.
    //http://stackoverflow.com/questions/6416050/how-to-create-a-trie-in-c-sharp
    public class Trie
    {
        public Trie(string[] words)
        {
            this.Root = new Node();

            for (int w = 0; w < words.Length; w++)
            {
                var word = words[w];
                var node = Root;
                for (int len = 1; len <= word.Length - 1; len++)
                {
                    var letter = word[len - 1];
                    Node next;
                    next = new Node();
                    if (len == word.Length)
                    {
                        next.Word = word;
                    }

                    if (node.Edges.ContainsKey(letter))
                    {
                        next = node.Edges[letter];
                    }
                    else
                    {
                        next.Word = word;
                        node.Edges.Add(letter, next);
                    }

                    node = next;
                }
            }
        }
        public Node Root { get; set; }

        public List<string> Find(string input)
        {
            return this.Root.Edges.Values.Where(x => x.Word.ToLower().Contains(input.ToLower())).Select(x => x.Word).ToList();
        }
    }
}