namespace _1.Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            //  7
            //  2 4
            //  3 2
            //  5 0
            //  3 5
            //  5 6
            //  5 1
            var nodes = GetNodes();
            FindParentNode(nodes);
            FindMiddles(nodes);
            FindLeaves(nodes);
            var parent = FindParentNode(nodes);
            Console.WriteLine("Longest path length: {0}", parent.FindLongestPath());
        }

        public static List<Node> GetNodes()
        {
            int count = int.Parse(Console.ReadLine());
            var nodesSoFar = new HashSet<int>();
            var nodes = new List<Node>();
            while (count > 1)
            {
                string[] input = Console.ReadLine().Split(' ');
                int parentValue = int.Parse(input[0]);
                int childValue = int.Parse(input[1]);
                var parent = nodes.FirstOrDefault(n => n.Value == parentValue);
                var child = nodes.FirstOrDefault(n => n.Value == childValue);
                if (child == null)
                {
                    child = new Node(childValue);
                    nodes.Add(child);
                }

                if (parent == null)
                {
                    parent = new Node(parentValue);
                    nodes.Add(parent);
                }

                parent.AddChild(child);
                count--;
            }
            return nodes;
        }

        public static Node FindParentNode(List<Node> nodes)
        {
            foreach (var node in nodes)
            {
                if (node.Parent == null)
                {
                    Console.WriteLine("The parent node is: {0}", node.Value);
                    return node;
                }
            }
            return null;
        }

        public static void FindMiddles(List<Node> nodes)
        {
            foreach (var node in nodes)
            {
                if (node.Parent != null && node.Children.Count > 0)
                {
                    Console.WriteLine("Middle node - {0}", node.Value);
                }
            }
        }

        public static void FindLeaves(List<Node> nodes)
        {
            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    Console.WriteLine("Leaf node - {0}", node.Value);
                }
            }
        }
    }
}
