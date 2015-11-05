namespace _1.Tree
{
    using System.Collections.Generic;

    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
            this.Children = new List<Node>();
            this.Parent = null;
        }

        public int ChildrenCount
        {
            get { return this.Children.Count; }
        }

        public List<Node> Children { get; set; }

        public Node Parent { get; set; }

        public int Value { get; set; }

        public void AddChild(Node child)
        {
            this.Children.Add(child);
            child.Parent = this;
        }

        public int CalculateSum()
        {
            int sum = 0;
            if (this.Parent == null)
            {
                sum += this.Value;
            }

            if (this.ChildrenCount == 0)
            {
                return 0;
            }

            sum += CalculateSum(this.Children);

            foreach (var node in this.Children)
            {
                sum += node.CalculateSum();
            }
            return sum;
        }

        private int CalculateSum(List<Node> nodes)
        {
            int sum = 0;
            foreach (var node in nodes)
            {
                sum += node.Value;
            }
            return sum;
        }

    }
}
