using System;
using System.Text;

namespace Task1FindTheRoot
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= N - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
            }

            // Task1 a.Find the root node
            var root = FindTheRood(nodes);
            Console.WriteLine($"The root: {root.Value}");

            // Task1 b.Find all leaf nodes
            var findAllLeaf = FindAllLeaf(nodes);
            Console.Write($"All leaf in tree: {findAllLeaf}");

            // Task1 c.Find all middle nodes
            var allMiddleNodes = FindMiddleNodes(nodes);
            Console.Write($"All middle nodes: {allMiddleNodes}");

        }

        // Task1 a.Find the root node
        public static Node<int> FindTheRood(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < nodes.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }
            throw new ArgumentException("There have no root.");
        }

        // Task1 b.Find all leaf nodes
        public static string FindAllLeaf(Node<int>[] nodes)
        {            
            StringBuilder sb = new StringBuilder();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    sb.AppendFormat("{0}, ", node.Value);                    
                }
            }                      
            sb.Remove(sb.Length - 2, 2);
            sb.AppendLine();

            return sb.ToString();
        }

        // Task1 c.Find all middle nodes
        public static string FindMiddleNodes(Node<int>[] nodes)
        {
            var sb = new StringBuilder();
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            foreach (var node in nodes)
            {
                if (hasParent[node.Value] && node.Children.Count > 0)
                {
                    sb.AppendFormat("{0}, ", node.Value);
                }
            }
            sb.Remove(sb.Length - 2, 2);
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
